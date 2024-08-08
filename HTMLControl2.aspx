<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTMLControl2.aspx.cs" Inherits="WebApplication1.HTMLControl2" %>

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
		<input type="checkbox" id="checkbox1" onserverchange="checkbox1_Change" runat="server">
	<p>
		<input type="radio" id="radio1" name="radioGroup" onserverchange="radio_Change" runat="server">
		<input type="radio" id="radio2" name="radioGroup" onserverchange="radio_Change" runat="server">
	<p>
		<select id="select1" onserverchange="select1_Change" runat="server">
			<option value="A">
				Value 1</option>
			<option value="B">
				Value 2</option>
			<option value="C">
				Value 3</option>
		</select>
	<p>
		<input type="submit" id="button1" onserverclick="button1_Click" value="Push Me" runat="server">
	<p>
		<div id="div1" runat="server" />
        </div>
    </form>
</body>
</html>
