<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="BorrowReport.aspx.vb" Inherits="TreasuryLoan.BorrowReport" %>
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
				Width="912px" Height="32px" BackColor="Navy">
				<asp:panel id="Panel2" style="Z-INDEX: 117; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
					BackColor="Navy" Height="11px" Width="869px"></asp:panel>
			</asp:panel><asp:panel id="Panel3" style="Z-INDEX: 110; LEFT: 0px; POSITION: absolute; TOP: 8px" runat="server"
				Width="16px" Height="528px" BackColor="Navy"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 456px" runat="server"
				Width="896px" Height="80px" BackColor="Navy">Panel</asp:panel>
			<DIV style="Z-INDEX: 103; LEFT: 16px; WIDTH: 880px; POSITION: absolute; TOP: 16px; HEIGHT: 45px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4">
							<DIV id="Layer2" style="Z-INDEX: 100; LEFT: 16px; OVERFLOW: scroll; WIDTH: 796px; POSITION: absolute; TOP: 120px; HEIGHT: 264px"
								tabIndex="10"><asp:datagrid id="Datagrid2" style="Design_Time_Lock: False" runat="server" Width="772px" Height="12px"
									BackColor="White" CellPadding="4" BorderWidth="1px" BorderStyle="None" BorderColor="#3366CC" Font-Names="Tahoma"
									ItemStyle-Font-Size="12px" ItemStyle-Font-Name="verdana" ItemStyle-BackColor="Gainsboro" HeaderStyle-ForeColor="White"
									HeaderStyle-Font-Size="12px" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Bold="True" HeaderStyle-BackColor="IndianRed"
									Design_Time_Lock="False" AutoGenerateColumns="False">
									<FooterStyle Font-Size="12px" Font-Names="Verdana" HorizontalAlign="Right" ForeColor="#003399"
										BackColor="#99CCCC"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
									<ItemStyle Font-Size="12px" Font-Names="verdana" ForeColor="#003399" BackColor="White"></ItemStyle>
									<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
									<Columns>
										<asp:HyperLinkColumn Visible="False" Target="_new" DataTextField="Id" HeaderText="Id" DataTextFormatString="{0}">
											<HeaderStyle Width="0.8in"></HeaderStyle>
											<ItemStyle HorizontalAlign="Right" VerticalAlign="Top"></ItemStyle>
										</asp:HyperLinkColumn>
										<asp:HyperLinkColumn Target="_new" DataTextField="LiNo" HeaderText="Loan No" DataTextFormatString="{0}">
											<HeaderStyle Width="0.6in"></HeaderStyle>
											<ItemStyle Font-Underline="True" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
										</asp:HyperLinkColumn>
										<asp:TemplateColumn HeaderText="Lender Name">
											<HeaderStyle Width="0.6in"></HeaderStyle>
											<ItemStyle HorizontalAlign="Left"></ItemStyle>
											<ItemTemplate>
												<asp:HyperLink id=HyperLink2 runat="server" Width="80px" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.BrName", "{0}") %>'>
												</asp:HyperLink>
											</ItemTemplate>
										</asp:TemplateColumn>
										<asp:TemplateColumn HeaderText="Date">
											<HeaderStyle Width="0.6in"></HeaderStyle>
											<ItemTemplate>
												<asp:HyperLink id=HyperLink1 runat="server" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.LiDate", "{0}") %>'>
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
										<asp:TemplateColumn HeaderText="Maturity Date">
											<HeaderStyle Width="0.8in"></HeaderStyle>
											<ItemStyle HorizontalAlign="Right"></ItemStyle>
											<ItemTemplate>
												<asp:HyperLink runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Libdate", "{0}") %>' NavigateUrl="" Target="_new" ID="Hyperlink4" NAME="Hyperlink4">
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
												<asp:HyperLink id="Hyperlink5" runat="server" Width="64px" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.LiIntRate", "{0:#######.00}") %>'>
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
										<asp:BoundColumn Visible="False" DataField="BrName" HeaderText="Borrower Name" DataFormatString="{0}">
											<HeaderStyle Width="0.6in"></HeaderStyle>
											<ItemStyle HorizontalAlign="Left"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn Visible="False" DataField="LiIntRate" HeaderText="Price">
											<HeaderStyle Width="0.6in"></HeaderStyle>
											<ItemStyle HorizontalAlign="Right"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn Visible="False" DataField="LiIntPmt" HeaderText="Opernning Stk">
											<HeaderStyle Width="0.6in"></HeaderStyle>
											<ItemStyle HorizontalAlign="Right"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn Visible="False" DataField="TotAmt" HeaderText="Borrower Name" DataFormatString="{0}">
											<HeaderStyle Width="0.6in"></HeaderStyle>
											<ItemStyle HorizontalAlign="Left"></ItemStyle>
										</asp:BoundColumn>
									</Columns>
									<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
								</asp:datagrid></DIV>
							Pending Borrow&nbsp;Debit Invoice</FONT></FONT></FONT></DIV>
			<asp:panel id="Panel4" style="Z-INDEX: 105; LEFT: 0px; POSITION: absolute; TOP: 536px" runat="server"
				Width="901px" Height="22px" BackColor="Navy"></asp:panel><asp:label id="Label7" style="Z-INDEX: 102; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Width="88px" Height="16px">Label</asp:label><asp:panel id="Panel1" style="Z-INDEX: 104; LEFT: 832px; POSITION: absolute; TOP: 8px" runat="server"
				Width="72px" Height="456px" BackColor="Navy" BackImageUrl="Menu/DSINEW1.JPG"></asp:panel><asp:label id="Label4" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 72px" runat="server"
				Width="97px" Height="24px">Borrower</asp:label><asp:dropdownlist id="LstBorrower" style="Z-INDEX: 107; LEFT: 160px; POSITION: absolute; TOP: 72px"
				tabIndex="8" runat="server" Width="376px" Height="32px" AutoPostBack="True"></asp:dropdownlist><asp:imagebutton id="ImageButton3" style="Z-INDEX: 108; LEFT: 616px; POSITION: absolute; TOP: 408px"
				runat="server" Width="56px" Height="32px" ImageUrl="iCO\print.jpg"></asp:imagebutton><asp:label id="L1" style="Z-INDEX: 111; LEFT: 384px; POSITION: absolute; TOP: 416px" runat="server"
				Width="160px" Height="24px"></asp:label>
			<asp:Button id="Button1" style="Z-INDEX: 112; LEFT: 624px; POSITION: absolute; TOP: 72px" runat="server"
				Width="101px" Text="All Borrowers"></asp:Button></form>
	</body>
</HTML>
