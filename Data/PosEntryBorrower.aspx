<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PosEntryBorrower.aspx.vb" Inherits="TreasuryLoan.PosEntryBorrower" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#f0f8ff" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel3" style="Z-INDEX: 122; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="Navy" Width="24px" Height="650px">
				<asp:panel id="Panel8" style="Z-INDEX: 117; LEFT: 24px; POSITION: absolute; TOP: 440px" runat="server"
					Height="46px" Width="952px" BackColor="Navy">Panel 
<asp:panel id="Panel5" runat="server" Height="62px" Width="890px">Panel</asp:panel></asp:panel>
			</asp:panel>
			<DIV id="Layer1" style="Z-INDEX: 101; LEFT: 24px; OVERFLOW: scroll; WIDTH: 728px; POSITION: absolute; TOP: 280px; HEIGHT: 166px"><asp:datagrid id="MyDataGrid" runat="server" BackColor="White" Width="760px" Height="120px" BorderColor="#E7E7FF"
					Font-Bold="True" GridLines="Horizontal" BorderWidth="1px" BorderStyle="None" Font-Names="Tahoma" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel"
					OnEditcommand="MyDataGrid_EditCommand" AutogenerateColumns="False" Font-Size="12pt" Font-Name="Tahoma" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
					cellpadding="3">
					<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller" BackColor="#F7F7F7"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Tahoma" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
					<Columns>
						<asp:TemplateColumn Visible="False">
							<ItemTemplate>
								<asp:LinkButton id="lbtnEdit" runat="server" Text="<img border=0 src=images/dtg_edit.gif alt=edit>"
									CommandName="Edit"></asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton id="lbtnUpdate" runat="server" Text="<img  border=0 src=images/dtg_update.gif alt=save/update>"
									CommandName="Update"></asp:LinkButton>
								<asp:LinkButton id="lbtnCancel" runat="server" Text="<img border=0 src=images/dtg_cancel.gif alt=cancel>"
									CommandName="Cancel"></asp:LinkButton>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=images/delete.jpg alt=delete>"
									CommandName="Delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="BrCode" HeaderText="Code">
							<HeaderStyle Width="0.8in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="BrName" HeaderText="Borrower Name">
							<HeaderStyle Width="3.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="BrAdd1" HeaderText="Borrower Address">
							<HeaderStyle Width="2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="BrEmail" HeaderText="E_Mail   ">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:button id="BtnEdit" style="Z-INDEX: 102; LEFT: 80px; POSITION: absolute; TOP: 584px" tabIndex="8"
				runat="server" Width="64px" Visible="False" Font-Bold="True" Enabled="False" Text="Edit"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 106; LEFT: 320px; POSITION: absolute; TOP: 584px" tabIndex="11"
				runat="server" Width="64px" Visible="False" Font-Bold="True" Enabled="False" Text="Save"></asp:button><asp:button id="BtnCle" style="Z-INDEX: 103; LEFT: 152px; POSITION: absolute; TOP: 584px" tabIndex="9"
				runat="server" Width="72px" Height="24px" Visible="False" Font-Bold="True" Enabled="False" Text="Clear"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 100; LEFT: 8px; POSITION: absolute; TOP: 584px" tabIndex="7"
				runat="server" Width="64px" Visible="False" Font-Bold="True" Enabled="False" Text="Add"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 104; LEFT: 240px; POSITION: absolute; TOP: 584px" tabIndex="11"
				runat="server" Width="64px" Visible="False" Font-Bold="True" Enabled="False" Text="Delete"></asp:button><asp:textbox id="TxtTelno" style="Z-INDEX: 107; LEFT: 136px; POSITION: absolute; TOP: 240px"
				runat="server" Width="390px" Visible="False" MaxLength="30"></asp:textbox><asp:textbox id="TxtComNam" style="Z-INDEX: 108; LEFT: 376px; POSITION: absolute; TOP: 64px"
				tabIndex="3" runat="server" Width="410px" MaxLength="40"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 109; LEFT: 32px; POSITION: absolute; TOP: 216px" runat="server"
				Width="58px" Height="16px">E_mail</asp:label><asp:textbox id="TxtComPer" style="Z-INDEX: 110; LEFT: 136px; POSITION: absolute; TOP: 168px"
				tabIndex="10" runat="server" Width="392px" MaxLength="30"></asp:textbox><asp:textbox id="TxtComAdd1" style="Z-INDEX: 111; LEFT: 136px; POSITION: absolute; TOP: 96px"
				runat="server" Width="392px" MaxLength="30"></asp:textbox><asp:textbox id="TxtComNo" style="Z-INDEX: 112; LEFT: 136px; POSITION: absolute; TOP: 64px" tabIndex="1"
				runat="server" Width="56px" Height="20px" AutoPostBack="True"></asp:textbox><asp:textbox id="Txtemail" style="Z-INDEX: 113; LEFT: 136px; POSITION: absolute; TOP: 216px"
				tabIndex="4" runat="server" Width="390px" MaxLength="30"></asp:textbox><asp:label id="Label8" style="Z-INDEX: 114; LEFT: 264px; POSITION: absolute; TOP: 64px" runat="server"
				Width="104px" Height="16px">Borrower Name</asp:label><asp:label id="Invoice" style="Z-INDEX: 115; LEFT: 32px; POSITION: absolute; TOP: 64px" runat="server"
				Width="104px" Height="24px">Borrower Code</asp:label><asp:label id="Label11" style="Z-INDEX: 116; LEFT: 32px; POSITION: absolute; TOP: 168px" runat="server"
				Width="96px" Height="24px"> Contact</asp:label><asp:label id="Label10" style="Z-INDEX: 117; LEFT: 32px; POSITION: absolute; TOP: 96px" runat="server"
				Width="112px" Height="24px">Address</asp:label><asp:button id="Button1" style="Z-INDEX: 119; LEFT: 208px; POSITION: absolute; TOP: 64px" runat="server"
				Width="48px" Height="24px" Text="Search"></asp:button><asp:button id="BttIns1" style="Z-INDEX: 120; LEFT: 608px; POSITION: absolute; TOP: 248px" runat="server"
				Width="56px" Height="24px" Text="Insert"></asp:button>
			<DIV style="Z-INDEX: 121; LEFT: 16px; WIDTH: 944px; POSITION: absolute; TOP: -32px; HEIGHT: 71px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4"><asp:panel id="Panel2" runat="server" BackColor="Navy" Width="952px" Height="40px">Panel</asp:panel></FONT>Borrower&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</FONT></FONT></DIV>
			<asp:panel id="Panel6" style="Z-INDEX: 123; LEFT: 784px; POSITION: absolute; TOP: 56px" runat="server"
				BackColor="Navy" Width="184px" Height="384px" BackImageUrl="Menu/DSINEW1.JPG">l 
<asp:Panel id="Panel7" runat="server" Height="8px" Width="1096px" BackColor="Navy"></asp:Panel></asp:panel><asp:textbox id="TxtDsgn" style="Z-INDEX: 124; LEFT: 136px; POSITION: absolute; TOP: 192px" tabIndex="10"
				runat="server" Width="390px" MaxLength="30"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 126; LEFT: 32px; POSITION: absolute; TOP: 192px" runat="server"
				Width="96px" Height="24px"> Designation</asp:label><asp:label id="Label2" style="Z-INDEX: 127; LEFT: 32px; POSITION: absolute; TOP: 240px" runat="server"
				Width="58px" Height="16px" Visible="False">TelNos</asp:label><asp:textbox id="TxtComAdd2" style="Z-INDEX: 128; LEFT: 136px; POSITION: absolute; TOP: 120px"
				runat="server" Width="392px" MaxLength="30"></asp:textbox><asp:textbox id="TxtComAdd3" style="Z-INDEX: 129; LEFT: 136px; POSITION: absolute; TOP: 144px"
				runat="server" Width="296px" MaxLength="20"></asp:textbox><asp:label id="Label4" style="Z-INDEX: 130; LEFT: 544px; POSITION: absolute; TOP: 96px" runat="server"
				Width="80px" Height="16px">Short  Name</asp:label><asp:textbox id="TxtSName" style="Z-INDEX: 131; LEFT: 632px; POSITION: absolute; TOP: 96px" tabIndex="1"
				runat="server" Width="64px" Height="20px" AutoPostBack="True"></asp:textbox></form>
	</body>
</HTML>
