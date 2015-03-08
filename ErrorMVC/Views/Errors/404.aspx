<%@ Page Language="C#" %>
<%
    Response.StatusCode = 404;

    Response.ContentType = "text/html; charset=utf-8";

    Response.WriteFile(MapPath("~/Views/Errors/404.html"));
%>