<%@ Page Language="C#" %>
<%
    Response.StatusCode = 500;

    Response.ContentType = "text/html; charset=utf-8";

    Response.WriteFile(MapPath("~/Views/Errors/500.html"));
%>