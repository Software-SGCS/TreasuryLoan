<%@ Page Language="vb" AutoEventWireup="false" Codebehind="LoanReg.aspx.vb" Inherits="TreasuryLoan.LoanReg" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
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
			<asp:panel id="Panel7" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: -16px" runat="server"
				BackColor="Navy" Height="32px" Width="920px">
				<asp:panel id="Panel2" style="Z-INDEX: 117; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
					BackColor="Navy" Height="11px" Width="869px"></asp:panel>
			</asp:panel><asp:panel id="Panel3" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 8px" runat="server"
				BackColor="Navy" Height="568px" Width="16px"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 108; LEFT: 0px; POSITION: absolute; TOP: 576px" runat="server"
				BackColor="Navy" Height="80px" Width="915px">Panel 
<asp:panel id="Panel4" runat="server" BackColor="Navy" Height="22px" Width="901px"></asp:panel></asp:panel>
			<DIV style="Z-INDEX: 103; LEFT: 16px; WIDTH: 880px; POSITION: absolute; TOP: 16px; HEIGHT: 8px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4">&nbsp; 
							Loan Register</FONT></FONT></FONT></DIV>
			<asp:label id="Label7" style="Z-INDEX: 102; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Height="16px" Width="88px">Label</asp:label><asp:panel id="Panel1" style="Z-INDEX: 104; LEFT: 832px; POSITION: absolute; TOP: 16px" runat="server"
				BackColor="Navy" Height="560px" Width="82px" BackImageUrl="file:///C:\Inetpub\wwwroot\TreasuryLoan\Menu\EmpMaster4.jpg"></asp:panel><asp:label id="Label4" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 56px" runat="server"
				Height="24px" Width="97px" Visible="False">Borrower</asp:label><asp:dropdownlist id="LstBorrower" style="Z-INDEX: 106; LEFT: 160px; POSITION: absolute; TOP: 56px"
				tabIndex="8" runat="server" Height="32px" Width="376px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:imagebutton id="ImageButton3" style="Z-INDEX: 107; LEFT: 608px; POSITION: absolute; TOP: 584px"
				runat="server" Height="32px" Width="56px" ImageUrl="iCO\print.jpg"></asp:imagebutton><asp:button id="Button1" style="Z-INDEX: 110; LEFT: 568px; POSITION: absolute; TOP: 56px" runat="server"
				Width="101px" Visible="False" Text="All Borrowers"></asp:button><asp:label id="L1" style="Z-INDEX: 111; LEFT: 16px; POSITION: absolute; TOP: 536px" runat="server"
				Height="24px" Width="160px"></asp:label><FONT face="Tahoma" size="4"></FONT>
			<DIV id="Layer2" style="Z-INDEX: 112; LEFT: 24px; OVERFLOW: scroll; WIDTH: 798px; POSITION: absolute; TOP: 64px; HEIGHT: 488px"
				tabIndex="10"><asp:datagrid id="Datagrid2" style="Design_Time_Lock: False" runat="server" BackColor="#CCCCCC"
					Height="68px" Width="766px" BorderStyle="Solid" CellPadding="4" BorderWidth="3px" BorderColor="#999999"
					Font-Names="Tahoma" ItemStyle-Font-Size="10px" ItemStyle-Font-Name="verdana" ItemStyle-BackColor="Gainsboro"
					HeaderStyle-ForeColor="White" HeaderStyle-Font-Size="10px" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Bold="True"
					HeaderStyle-BackColor="IndianRed" Design_Time_Lock="False" AutoGenerateColumns="False" ForeColor="Black"
					CellSpacing="2">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
					<ItemStyle Font-Size="10px" Font-Names="verdana" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="10px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
					<FooterStyle Font-Size="10px" Font-Names="Verdana" HorizontalAlign="Right" BackColor="#CCCCCC"></FooterStyle>
					<Columns>
						<asp:HyperLinkColumn Visible="False" Target="_new" DataTextField="Id" HeaderText="Id" DataTextFormatString="{0}">
							<HeaderStyle Width="0.8in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right" VerticalAlign="Top"></ItemStyle>
						</asp:HyperLinkColumn>
						<asp:HyperLinkColumn Target="_new" DataTextField="LiNo" HeaderText="New Loan RefNo" DataTextFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle Font-Underline="True" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:HyperLinkColumn>
						<asp:HyperLinkColumn Target="_new" DataTextField="LiprLno" HeaderText="Pre Loan RefNo" DataTextFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle Font-Underline="True" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:HyperLinkColumn>
						<asp:TemplateColumn HeaderText="Borrower Name">
							<HeaderStyle Width="0.3in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink2 runat="server" Height="8px" Width="40px" Text='<%# DataBinder.Eval(Container, "DataItem.BrName", "{0}") %>' NavigateUrl="" Target="_new">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Lender Name">
							<HeaderStyle Width="0.3in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=Hyperlink8 runat="server" Width="40px" Text='<%# DataBinder.Eval(Container, "DataItem.LeName", "{0}") %>' NavigateUrl="" Target="_new">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Date">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Width="40px" Text='<%# DataBinder.Eval(Container, "DataItem.LiDate", "{0}") %>' NavigateUrl="" Target="_new">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Currency">
							<HeaderStyle Width="0.8in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=Hypnk3 runat="server" Width="40px" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.LiCur", "{0}") %>'>
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Capital">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink3 runat="server" Width="64px" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.LiAmt", "{0:#######.00}") %>'>
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Rate">
							<HeaderStyle Width="0.4in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=Hyperlink5 runat="server" Width="30px" Text='<%# DataBinder.Eval(Container, "DataItem.LiIntRate", "{0:#######.00}") %>' NavigateUrl="" Target="_new">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Interest">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id="Hyperlink6" runat="server" Width="64px" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.LiIntPmt", "{0:#######.00}") %>'>
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Maturity Date">
							<HeaderStyle Width="0.8in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Libdate", "{0}") %>' NavigateUrl="" Target="_new" ID="Hyperlink4" >
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Maturity Amount">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id="Hyperlink7" runat="server" Width="64px" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.TotAmt", "{0:#######.00}") %>'>
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn Visible="False" DataField="LiNo" HeaderText="test"></asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="LiDate" HeaderText="Description"></asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="LiCur" HeaderText="Quantity Type">
							<HeaderStyle Width="0.6in"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="LiAmt" HeaderText="Price">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Libdate" HeaderText="Opernning Stk">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="LiIntRate" HeaderText="Price">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="BrName" HeaderText="Borrower Name" DataFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="LiIntPmt" HeaderText="Opernning Stk">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="TotAmt" HeaderText="Borrower Name" DataFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="LiprLno" HeaderText="PreRef"></asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="SetFg" HeaderText="flag" DataFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="ChqNo" HeaderText="Sett:Amount" DataFormatString="{0:D}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Sdt" HeaderText="Sett:Date" DataFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Note" HeaderText="Note" DataFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Note" HeaderText="Note"></asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="Black" BackColor="#CCCCCC" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</form>
	</body>
</HTML>
