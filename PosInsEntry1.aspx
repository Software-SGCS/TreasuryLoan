<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PosInsEntry1.aspx.vb" Inherits="TreasuryLoan.PosInsEntry1" %>
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
			<asp:panel id="Panel2" style="Z-INDEX: 106; LEFT: 24px; POSITION: absolute; TOP: -8px" runat="server"
				BackColor="Navy" Width="944px" Height="8px"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 103; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="Navy" Width="32px" Height="524px">
				<asp:imagebutton id="ImageButton3" style="Z-INDEX: 105; LEFT: 200px; POSITION: absolute; TOP: 488px"
					runat="server" Height="24px" Width="80px" ImageUrl="iCO\print.jpg" Visible="False"></asp:imagebutton>
				<asp:TextBox id="TxtVal2" style="Z-INDEX: 106; LEFT: 520px; POSITION: absolute; TOP: 496px" runat="server"
					Width="80px" Visible="False"></asp:TextBox>
				<asp:TextBox id="TxtVal3" style="Z-INDEX: 107; LEFT: 608px; POSITION: absolute; TOP: 496px" runat="server"
					Width="80px" Visible="False"></asp:TextBox>
				<asp:panel id="Panel5" style="Z-INDEX: 108; LEFT: 918px; POSITION: absolute; TOP: 48px" runat="server"
					Height="498px" Width="58px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel>
			</asp:panel><asp:panel id="Panel7" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 40px" runat="server"
				BackColor="Navy" Width="944px" Height="11px"></asp:panel>
			<DIV style="Z-INDEX: 107; LEFT: 16px; WIDTH: 944px; POSITION: absolute; TOP: 16px; HEIGHT: 24px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4"> 
							&nbsp;Monthly Settelement</FONT></FONT></FONT></DIV>
			<div id="Layer1" style="Z-INDEX: 101; LEFT: 24px; OVERFLOW: scroll; WIDTH: 856px; POSITION: relative; TOP: 56px; HEIGHT: 400px"><asp:datagrid id="DataGrid1" runat="server" BackColor="White" Width="840px" Height="192px" BorderColor="#E7E7FF"
					BorderWidth="1px" AutoGenerateColumns="False" BorderStyle="None" CellPadding="7" GridLines="Horizontal" ShowFooter="True" Font-Size="Small">
					<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
					<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
					<HeaderStyle Font-Size="X-Small" Font-Names="Tahoma" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
					<Columns>
						<asp:BoundColumn Visible="False" DataField="Raw_ItmCode" HeaderText="Material Code">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Des" HeaderText="Description">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Itm_Pri" HeaderText="Sales Price">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_OpStk" HeaderText="Operning Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="ChqNo" HeaderText="Submit Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Sdt" HeaderText="Employee No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="debank" HeaderText="Employee No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Lperiod" HeaderText="Employee No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Loan Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_ItmCode" runat="server" Height="16px" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Loan No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_des" runat="server" Width="42px" Height="16px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Amount">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Itm_Pri" runat="server" Width="114px"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Interestt">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_OpStk" runat="server" Width="74px"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Period">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Lperiod" runat="server" Width="74px"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Cheque No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="chqNo" runat="server" Width="74px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Deposite Bank">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="DeBank" runat="server" Width="82px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Note">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="lnote" runat="server" Width="90px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Deposite Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="sdt" runat="server" Width="90px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></div>
			<asp:panel id="Panel4" style="Z-INDEX: 108; LEFT: 0px; POSITION: absolute; TOP: 526px" runat="server"
				BackColor="Navy" Width="968px" Height="43px"></asp:panel><asp:label id="Label7" style="Z-INDEX: 104; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Width="88px" Height="16px">Label</asp:label><asp:button id="BtnUpdate" style="Z-INDEX: 105; LEFT: 48px; POSITION: absolute; TOP: 488px"
				runat="server" Width="80px" Text="Update"></asp:button><asp:textbox id="TxtQty3" style="Z-INDEX: 109; LEFT: 624px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtQty2" style="Z-INDEX: 110; LEFT: 536px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtQty1" style="Z-INDEX: 111; LEFT: 448px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px" Visible="False"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 112; LEFT: 344px; POSITION: absolute; TOP: 472px" runat="server"
				Width="32px" Height="16px" Visible="False">Qty</asp:label><asp:label id="Label4" style="Z-INDEX: 113; LEFT: 344px; POSITION: absolute; TOP: 504px" runat="server"
				Width="64px" Height="16px" Visible="False">Value</asp:label><asp:textbox id="TxtVal1" style="Z-INDEX: 114; LEFT: 424px; POSITION: absolute; TOP: 496px" runat="server"
				Width="80px" Visible="False"></asp:textbox><asp:label id="L1" style="Z-INDEX: 115; LEFT: 688px; POSITION: absolute; TOP: 584px" runat="server"
				Width="128px" Height="24px"></asp:label></form>
	</body>
</HTML>
