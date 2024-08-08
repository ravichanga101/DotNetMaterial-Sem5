<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTMLControl1.aspx.cs" Inherits="WebApplication1.HTMLControl1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
   <input type="text" id="text1" onserverchange="text1_Change" value="initial value" runat="server">
<p>
	<input type="submit" id="button1" onserverclick="button1_Click" value="Push Me" runat="server">
<p>
	<div id="div1" runat="server" />
        </div>
    </form>
</body>
</html>
