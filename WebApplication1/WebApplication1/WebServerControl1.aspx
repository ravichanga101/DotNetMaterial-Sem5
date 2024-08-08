<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServerControl1.aspx.cs" Inherits="WebApplication1.WebServerControl1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
	<tr>
		<td>
			<asp:textbox id="text1" onTextChanged="text1_TextChanged" value="initial value" runat="server" />
			<p>
				<asp:checkbox id="checkbox1" onCheckedChanged="checkbox1_CheckedChanged" runat="server" />
			<p>
				<asp:radiobutton id="radio1" Groupname="radioGroup" onCheckedChanged="radio_CheckedChanged" runat="server" />
				<asp:radiobutton id="radio2" GroupName="radioGroup" onCheckedChanged="radio_CheckedChanged" runat="server" />
			<p>
				<asp:DropDownList id="dropdown1" onselectedIndexchanged="dropdown1_SelectedIndexChanged" runat="server" AutoPostBack="True">
					<asp:ListItem value="A">Value 1</asp:ListItem>
					<asp:ListItem value="B">Value 2</asp:ListItem>
					<asp:ListItem value="C">Value 3</asp:ListItem>
				</asp:DropDownList>
			<p>
				<asp:ListBox id="listbox1" Rows="4" onselectedIndexchanged="listbox1_SelectedIndexChanged" runat="server" AutoPostBack="True">
					<asp:ListItem value="A">Value 1</asp:ListItem>
					<asp:ListItem value="B">Value 2</asp:ListItem>
					<asp:ListItem value="C">Value 3</asp:ListItem>
					<asp:ListItem value="D">Value 4</asp:ListItem>
					<asp:ListItem value="E">Value 5</asp:ListItem>
					<asp:ListItem value="F">Value 6</asp:ListItem>
				</asp:ListBox>
			<p>
				<asp:ListBox id="listbox2" Rows="4" SelectionMode="Multiple" onselectedIndexchanged="listbox2_SelectedIndexChanged" runat="server">
					<asp:ListItem value="A">Value 1</asp:ListItem>
					<asp:ListItem value="B">Value 2</asp:ListItem>
					<asp:ListItem value="C">Value 3</asp:ListItem>
					<asp:ListItem value="D">Value 4</asp:ListItem>
					<asp:ListItem value="E">Value 5</asp:ListItem>
					<asp:ListItem value="F">Value 6</asp:ListItem>
				</asp:ListBox>
			<p>
		</td>
		<td>
			<asp:CheckBoxList id="checkboxlist1" onselectedIndexchanged="checkboxlist1_SelectedIndexChanged" runat="server">
				<asp:ListItem value="A">Item 1</asp:ListItem>
				<asp:ListItem value="B">Item 2</asp:ListItem>
				<asp:ListItem value="C">Item 3</asp:ListItem>
				<asp:ListItem value="D">Item 4</asp:ListItem>
				<asp:ListItem value="E">Item 5</asp:ListItem>
			</asp:CheckBoxList>
			<p>
				<asp:RadioButtonList id="radiobuttonlist1" onselectedIndexchanged="radiobuttonlist1_SelectedIndexChanged" runat="server">
					<asp:ListItem value="A">Item 1</asp:ListItem>
					<asp:ListItem value="B">Item 2</asp:ListItem>
					<asp:ListItem value="C">Item 3</asp:ListItem>
					<asp:ListItem value="D">Item 4</asp:ListItem>
					<asp:ListItem value="E">Item 5</asp:ListItem>
				</asp:RadioButtonList>
		</td>
	</tr>
</table>
<p>
	<asp:Button id="button1" onClick="button1_Click" text="Push Me" runat="server" />
<p>
	<asp:Label id="label1" runat="server" />
        </div>
    </form>
</body>
</html>
