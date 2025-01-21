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
			<asp:panel id="Panel2" style="Z-INDEX: 106; LEFT: 24px; POSITION: absolute; TOP: -8px" runat="server"
				BackColor="Navy" Width="944px" Height="8px"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 103; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="Navy" Width="32px" Height="568px">
				<asp:label id="Label3" style="Z-INDEX: 101; LEFT: 56px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="104px" BackColor="Lavender" Font-Bold="True" Visible="False">Company</asp:label>
				<asp:dropdownlist id="LstCat" style="Z-INDEX: 103; LEFT: 168px; POSITION: absolute; TOP: 80px" runat="server"
					Height="16px" Width="304px" Visible="False" AutoPostBack="True"></asp:dropdownlist>
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
				<asp:panel id="Panel5" style="Z-INDEX: 108; LEFT: 864px; POSITION: absolute; TOP: 48px" runat="server"
					Height="512px" Width="112px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel>
			</asp:panel><asp:panel id="Panel7" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="Navy" Width="944px" Height="16px"></asp:panel>
			<DIV style="Z-INDEX: 107; LEFT: 24px; WIDTH: 944px; POSITION: absolute; TOP: 8px; HEIGHT: 24px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4"> 
							&nbsp;LOAN SETTLEMENT</FONT></FONT></FONT></DIV>
			<DIV id="Layer1" style="Z-INDEX: 101; LEFT: 18px; OVERFLOW: scroll; WIDTH: 852px; POSITION: relative; TOP: 96px; HEIGHT: 396px">
				<asp:datagrid id="DataGrid1" runat="server" Height="12px" Width="832px" BackColor="White" Font-Size="Small"
					ShowFooter="True" GridLines="Horizontal" CellPadding="7" BorderStyle="None" AutoGenerateColumns="False"
					BorderWidth="1px" BorderColor="#E7E7FF">
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
						<asp:BoundColumn Visible="False" DataField="EmpChqNo" HeaderText="Submit Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Soh" HeaderText="Stock On Hand">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="EmpCno" HeaderText="Employee No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Loan Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_ItmCode" runat="server" Height="16px" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Loan #">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_des" runat="server" Width="16px" Height="16px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Loan Amount">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Itm_Pri" runat="server" Width="114px"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Interest">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_OpStk" runat="server" Width="74px"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Cheque No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="EmpchqNo" runat="server" Width="74px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Deposite Bank">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="EmpCno" runat="server" Width="82px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Note">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Soh" runat="server" Width="90px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:panel id="Panel4" style="Z-INDEX: 108; LEFT: -8px; POSITION: absolute; TOP: 560px" runat="server"
				BackColor="Navy" Width="976px" Height="43px"></asp:panel><asp:label id="Label7" style="Z-INDEX: 104; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Width="88px" Height="16px">Label</asp:label><asp:button id="BtnUpdate" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 472px"
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
