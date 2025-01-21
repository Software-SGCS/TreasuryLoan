<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PosInsEntry.aspx.vb" Inherits="TreasuryLoan.PosInsEntry" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>DataEntry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#f0f8ff" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel2" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: -8px" runat="server"
				BackColor="Navy" Width="1056px" Height="8px"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="Navy" Width="32px" Height="524px">
				<asp:dropdownlist id="LstCat" style="Z-INDEX: 103; LEFT: 168px; POSITION: absolute; TOP: 80px" runat="server"
					Height="16px" Width="304px" AutoPostBack="True" Visible="False"></asp:dropdownlist>
				<asp:textbox id="TxtYr" style="Z-INDEX: 104; LEFT: 480px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="56px" Visible="False"></asp:textbox>
				<asp:textbox id="TxtMt" style="Z-INDEX: 102; LEFT: 544px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="32px" Visible="False"></asp:textbox>
				<asp:imagebutton id="ImageButton3" style="Z-INDEX: 105; LEFT: 200px; POSITION: absolute; TOP: 488px"
					runat="server" Height="24px" Width="80px" Visible="False" ImageUrl="iCO\print.jpg"></asp:imagebutton>
				<asp:TextBox id="TxtVal2" style="Z-INDEX: 106; LEFT: 520px; POSITION: absolute; TOP: 496px" runat="server"
					Width="80px" Visible="False"></asp:TextBox>
				<asp:TextBox id="TxtVal3" style="Z-INDEX: 107; LEFT: 608px; POSITION: absolute; TOP: 496px" runat="server"
					Width="80px" Visible="False"></asp:TextBox>
			</asp:panel><asp:panel id="Panel7" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="Navy" Width="1057px" Height="16px"></asp:panel>
			<DIV style="Z-INDEX: 107; LEFT: 16px; WIDTH: 1065px; POSITION: absolute; TOP: 8px; HEIGHT: 24px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4">&nbsp; 
							Loan Settlement Entry</FONT></FONT></FONT></DIV>
			<div id="Layer1" style="Z-INDEX: 100; LEFT: 56px; OVERFLOW: scroll; WIDTH: 856px; POSITION: relative; TOP: 40px; HEIGHT: 416px"><asp:datagrid id="DataGrid1" runat="server" BackColor="White" Width="200px" Height="200px" BorderColor="#3366CC"
					BorderWidth="1px" AutoGenerateColumns="False" BorderStyle="None" CellPadding="4" ShowFooter="True" Font-Size="10px" Font-Names="verdana">
					<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
					<EditItemStyle ForeColor="#33CC00" BackColor="#00CC00"></EditItemStyle>
					<ItemStyle Font-Size="10px" Font-Names="verdana" ForeColor="#003399" BackColor="White"></ItemStyle>
					<ItemStyle Font-Size="10px" Font-Names="verdana" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="10px" Font-Names="verdana" Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
					<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
					<Columns>
						<asp:BoundColumn Visible="False" DataField="Raw_ItmCode" HeaderText="Material Code">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Des" HeaderText="Description">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Itm_Pri" HeaderText="Sales Price">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_OpStk" HeaderText="Operning Stock">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="EmpChqNo" HeaderText="Submit Date">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Soh" HeaderText="Stock On Hand">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="EmpCno" HeaderText="Employee No">
							<ItemStyle Font-Size="10pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Loan Date">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_ItmCode" runat="server" Height="16px" Width="98px" Font-Names="Tahoma" Font-Size="9pt">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Loan No">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_des" runat="server" Width="40px" Height="16px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Amount">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma" Font-Bold="True" HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Itm_Pri" runat="server" Width="50px"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Interest">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma" Font-Bold="True" HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_OpStk" runat="server" Width="50px"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Sett:Amount">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="EmpchqNo" runat="server" BackColor="White" Width="92px" Font-Size="9pt" Font-Names="Tahoma"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Date">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="EmpCno" runat="server" BackColor="White" Width="100px" Font-Size="9pt" Font-Names="Tahoma"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Remarks">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Soh" runat="server" BackColor="White" Width="196px" Font-Size="9pt" Font-Names="Tahoma"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="TotAmt" HeaderText="Total Amount">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Lsname" HeaderText="Lender">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Bsname" HeaderText="Borrower">
							<ItemStyle Font-Size="9pt" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></div>
			<asp:panel id="Panel4" style="Z-INDEX: 108; LEFT: 0px; POSITION: absolute; TOP: 526px" runat="server"
				BackColor="Navy" Width="1104px" Height="43px"></asp:panel><asp:label id="Label7" style="Z-INDEX: 103; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Width="88px" Height="16px">Label</asp:label><asp:button id="BtnUpdate" style="Z-INDEX: 104; LEFT: 64px; POSITION: absolute; TOP: 488px"
				runat="server" Width="80px" Text="Update"></asp:button><asp:textbox id="TxtQty3" style="Z-INDEX: 109; LEFT: 624px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtQty2" style="Z-INDEX: 110; LEFT: 536px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtQty1" style="Z-INDEX: 111; LEFT: 448px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px" Visible="False"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 112; LEFT: 344px; POSITION: absolute; TOP: 472px" runat="server"
				Width="32px" Height="16px" Visible="False">Qty</asp:label><asp:label id="Label4" style="Z-INDEX: 113; LEFT: 344px; POSITION: absolute; TOP: 504px" runat="server"
				Width="64px" Height="16px" Visible="False">Value</asp:label><asp:textbox id="TxtVal1" style="Z-INDEX: 114; LEFT: 424px; POSITION: absolute; TOP: 496px" runat="server"
				Width="80px" Visible="False"></asp:textbox><asp:label id="L1" style="Z-INDEX: 115; LEFT: 688px; POSITION: absolute; TOP: 584px" runat="server"
				Width="128px" Height="24px"></asp:label><asp:panel id="Panel5" style="Z-INDEX: 116; LEFT: 928px; POSITION: absolute; TOP: -8px" runat="server"
				BackColor="Desktop" Width="168px" Height="560px" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel></form>
	</body>
</HTML>
