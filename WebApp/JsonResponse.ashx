﻿<%@ WebHandler Language="C#" Class="JsonResponse" %>

using System;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Web.SessionState;
using CTR;
using DTO;

public class JsonResponse : IHttpHandler, IRequiresSessionState
{



 

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "application/json";

        DateTime start = new DateTime(2019, 1, 1);
        DateTime end = new DateTime(2019, 12, 30);

        start = start.AddSeconds(double.Parse(context.Request.QueryString["start"]));
        end = end.AddSeconds(double.Parse(context.Request.QueryString["end"]));


        String result = String.Empty;

        result += "[";

        List<int> idList = new List<int>();
        foreach (CalendarEvent cevent in CtrlHorarioEntrenamiento.getEvents(start, end))
        {
            result += convertCalendarEventIntoString(cevent);
            idList.Add(cevent.id);
        }

        if (result.EndsWith(","))
        {
            result = result.Substring(0, result.Length - 1);
        }

        result += "]";
        //store list of event ids in Session, so that it can be accessed in web methods
        context.Session["idList"] = idList;

        context.Response.Write(result);
    }

    private String convertCalendarEventIntoString(CalendarEvent cevent)
    {
        String allDay = "true";
        if (ConvertToTimestamp(cevent.start).ToString().Equals(ConvertToTimestamp(cevent.end).ToString()))
        {

            if (cevent.start.Hour == 0 && cevent.start.Minute == 0 && cevent.start.Second == 0)
            {
                allDay = "true";
            }
            else
            {
                allDay = "false";
            }
        }
        else
        {
            if (cevent.start.Hour == 0 && cevent.start.Minute == 0 && cevent.start.Second == 0
                && cevent.end.Hour == 0 && cevent.end.Minute == 0 && cevent.end.Second == 0)
            {
                allDay = "true";
            }
            else
            {
                allDay = "false";
            }
        }
        return "{" +
                  "id: '" + cevent.id + "'," +
                  "title: '" + HttpContext.Current.Server.HtmlEncode(cevent.title) + "'," +
                  "start:  " + ConvertToTimestamp(cevent.start).ToString() + "," +
                  "end: " + ConvertToTimestamp(cevent.end).ToString() + "," +
                  //"start:  " + ConvertToTimestamp(cevent.start).ToString() + "," +
                  //"end: " + ConvertToTimestamp(cevent.end).ToString() + "," +
                  "allDay:" + allDay + "," +
                  "description: '" + HttpContext.Current.Server.HtmlEncode(cevent.description) + "'," +
                  //"sede: '" + 2 + "'" +
                  //"sede: '" + cevent.sede + "'" +
                  "sede: '" + Convert.ToInt32((cevent.sede).ToString()) + "'" +
                  "},";
    }


    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    private long ConvertToTimestamp(DateTime value)
    {


        long epoch = (value.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        return epoch;

    }

}