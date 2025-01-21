<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="LenderReport.aspx.vb" Inherits="TreasuryLoan.LenderReport" %>
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
				BackColor="Navy" Height="32px" Width="912px">
				<asp:panel id="Panel2" style="Z-INDEX: 117; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
					Width="869px" Height="11px" BackColor="Navy"></asp:panel>
			</asp:panel><asp:panel id="Panel3" style="Z-INDEX: 110; LEFT: 0px; POSITION: absolute; TOP: 8px" runat="server"
				BackColor="Navy" Height="528px" Width="16px"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 456px" runat="server"
				BackColor="Navy" Height="80px" Width="896px">Panel</asp:panel>
			<DIV style="Z-INDEX: 103; LEFT: 16px; WIDTH: 880px; POSITION: absolute; TOP: 16px; HEIGHT: 45px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4">
							<DIV id="Layer2" style="Z-INDEX: 100; LEFT: 16px; OVERFLOW: scroll; WIDTH: 796px; POSITION: absolute; TOP: 120px; HEIGHT: 264px"
								tabIndex="10"><asp:datagrid id="Datagrid2" style="Design_Time_Lock: False" runat="server" BackColor="White"
									Height="12px" Width="772px" AutoGenerateColumns="False" Design_Time_Lock="False" HeaderStyle-BackColor="IndianRed"
									HeaderStyle-Font-Bold="True" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Size="12px" HeaderStyle-ForeColor="White"
									ItemStyle-BackColor="Gainsboro" ItemStyle-Font-Name="verdana" ItemStyle-Font-Size="12px" Font-Names="Tahoma"
									BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
										<asp:TemplateColumn HeaderText="Borrower Name">
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
							Pending Lender Credit Invoice</FONT></FONT></FONT></DIV>
			<asp:panel id="Panel4" style="Z-INDEX: 105; LEFT: 0px; POSITION: absolute; TOP: 536px" runat="server"
				BackColor="Navy" Height="22px" Width="901px"></asp:panel><asp:label id="Label7" style="Z-INDEX: 102; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Height="16px" Width="88px">Label</asp:label><asp:panel id="Panel1" style="Z-INDEX: 104; LEFT: 832px; POSITION: absolute; TOP: 8px" runat="server"
				BackColor="Navy" Height="456px" Width="72px" BackImageUrl="Menu/DSINEW1.JPG"></asp:panel><asp:label id="Label4" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="97px" Visible="False">Lender</asp:label><asp:dropdownlist id="LstLender" style="Z-INDEX: 107; LEFT: 144px; POSITION: absolute; TOP: 72px"
				tabIndex="8" runat="server" Height="32px" Width="376px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:imagebutton id="ImageButton3" style="Z-INDEX: 108; LEFT: 728px; POSITION: absolute; TOP: 408px"
				runat="server" Height="32px" Width="56px" ImageUrl="iCO\print.jpg"></asp:imagebutton><asp:label id="L1" style="Z-INDEX: 111; LEFT: 384px; POSITION: absolute; TOP: 416px" runat="server"
				Height="24px" Width="160px"></asp:label><cr:crystalreportviewer id="CrystalReportViewer1" style="Z-INDEX: 112; LEFT: 24px; POSITION: absolute; TOP: 64px"
				runat="server" Height="50px" Width="350px" Visible="False"></cr:crystalreportviewer></form>
	</body>
</HTML>
