<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="LoanRegister.aspx.vb" Inherits="TreasuryLoan.LoanRegister" %>
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
				BackColor="Navy" Height="32px" Width="960px">
				<asp:panel id="Panel2" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
					Width="952px" Height="11px" BackColor="Navy"></asp:panel>
			</asp:panel><asp:panel id="Panel3" style="Z-INDEX: 108; LEFT: 0px; POSITION: absolute; TOP: 8px" runat="server"
				BackColor="Navy" Height="616px" Width="16px"></asp:panel>
			<DIV style="Z-INDEX: 103; LEFT: 24px; WIDTH: 903px; POSITION: absolute; TOP: 16px; HEIGHT: 16px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4"><FONT face="Calibri"><STRONG>LOAN 
									REGISTER</STRONG></FONT></FONT></FONT></FONT></DIV>
			<asp:panel id="Panel4" style="Z-INDEX: 105; LEFT: -8px; POSITION: absolute; TOP: 576px" runat="server"
				BackColor="Navy" Height="48px" Width="962px"></asp:panel><asp:label id="Label7" style="Z-INDEX: 102; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Height="16px" Width="88px">Label</asp:label><asp:panel id="Panel1" style="Z-INDEX: 104; LEFT: 864px; POSITION: absolute; TOP: -40px" runat="server"
				BackColor="Navy" Height="656px" Width="94px" BackImageUrl="Menu/DSINEW1.JPG"></asp:panel><asp:dropdownlist id="LstLender" style="Z-INDEX: 106; LEFT: 40px; POSITION: absolute; TOP: 72px" tabIndex="8"
				runat="server" Height="32px" Width="376px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:imagebutton id="ImageButton3" style="Z-INDEX: 107; LEFT: 712px; POSITION: absolute; TOP: 536px"
				runat="server" Height="32px" Width="56px" ImageUrl="iCO\print.jpg"></asp:imagebutton><asp:label id="L1" style="Z-INDEX: 109; LEFT: 384px; POSITION: absolute; TOP: 536px" runat="server"
				Height="24px" Width="160px"></asp:label><cr:crystalreportviewer id="CrystalReportViewer1" style="Z-INDEX: 110; LEFT: 24px; POSITION: absolute; TOP: 64px"
				runat="server" Height="50px" Width="350px" Visible="False"></cr:crystalreportviewer>
			<DIV id="Layer2" style="Z-INDEX: 112; LEFT: 16px; OVERFLOW: scroll; WIDTH: 840px; POSITION: absolute; TOP: 136px; HEIGHT: 376px"
				tabIndex="10"><asp:datagrid id="Datagrid2" style="Design_Time_Lock: False" runat="server" BackColor="White"
					Height="12px" Width="772px" GridLines="Vertical" AutoGenerateColumns="False" Design_Time_Lock="False" HeaderStyle-BackColor="IndianRed"
					HeaderStyle-Font-Bold="True" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Size="12px" HeaderStyle-ForeColor="White"
					ItemStyle-BackColor="Gainsboro" ItemStyle-Font-Name="verdana" ItemStyle-Font-Size="12px" Font-Names="Calibri"
					BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3">
					<FooterStyle Font-Size="12px" Font-Names="Verdana" HorizontalAlign="Right" ForeColor="Black"
						BackColor="#CCCCCC"></FooterStyle>
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
					<ItemStyle Font-Size="12px" Font-Names="verdana" ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
					<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="#000084"></HeaderStyle>
					<Columns>
						<asp:HyperLinkColumn Visible="False" Target="_new" DataTextField="Id" HeaderText="Id" DataTextFormatString="{0}">
							<HeaderStyle Width="0.8in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right" VerticalAlign="Top"></ItemStyle>
						</asp:HyperLinkColumn>
						<asp:HyperLinkColumn Target="_new" DataTextField="LENO1" HeaderText="NEW LOAN REF" DataTextFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle Font-Underline="True" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:HyperLinkColumn>
						<asp:HyperLinkColumn Target="_new" DataTextField="LiprLno" HeaderText="PRE LOAN REF" DataTextFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle Font-Underline="True" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:HyperLinkColumn>
						<asp:HyperLinkColumn Target="_new" DataTextField="LeSName" HeaderText="CTR" DataTextFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle Font-Underline="True" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:HyperLinkColumn>
						<asp:HyperLinkColumn Target="_new" DataTextField="BrSName" HeaderText="DTR" DataTextFormatString="{0}">
							<HeaderStyle Width="0.6in"></HeaderStyle>
							<ItemStyle Font-Underline="True" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:HyperLinkColumn>
						<asp:TemplateColumn HeaderText="EFECTIVE DATE">
							<HeaderStyle Width="0.8in"></HeaderStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LrDate", "{0}") %>' NavigateUrl="" Target="_new">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="MATURITY DATE">
							<HeaderStyle Width="0.8in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Lrbdate", "{0}") %>' NavigateUrl="" Target="_new" ID="Hyperlink4" NAME="Hyperlink4">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="  ">
							<HeaderStyle Width="0.4in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=Hyperlink10 runat="server" Width="40px" Target="_new" Text='<%# DataBinder.Eval(Container, "DataItem.LrcUR", "{0}") %>' NavigateUrl="" NAME="Hyperlink4">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="CAPITAL">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink3 runat="server" Width="96px" Target="_new" Text='<%# DataBinder.Eval(Container, "DataItem.LRAmt", "{0:###,###,###.00}") %>' NavigateUrl="">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="MATURITY AMOUNT">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=Hyperlink7 runat="server" Width="96px" Target="_new" Text='<%# DataBinder.Eval(Container, "DataItem.TotAmt", "{0:###,###,###.00}") %>' NavigateUrl="">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="INTEREST">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=Hyperlink6 runat="server" Width="88px" Target="_new" Text='<%# DataBinder.Eval(Container, "DataItem.LRIntPmt", "{0:###,###,###.00}") %>' NavigateUrl="">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="BANK-CHQ NO">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id="Hyperlink5" runat="server" Width="64px" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.LiChqNo", "{0:###,###,###.00}") %>'>
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="DTD BANK">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id="Hyperlink11" runat="server" Width="64px" Target="_new" NavigateUrl="" Text='<%# DataBinder.Eval(Container, "DataItem.LiDEBANK", "{0:###,###,###.00}") %>'>
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="NOTE                                     ">
							<HeaderStyle Width="3in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=Hyperlink12 runat="server" Width="288px" Text='<%# DataBinder.Eval(Container, "DataItem.LiNOTE", "{0:###,###,###.00}") %>' NavigateUrl="" Target="_new">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn Visible="FALSE" DataField="LRAmt" HeaderText="Payment Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="FALSE" DataField="LiChqNo" HeaderText="Employee #">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="FALSE" DataField="Setfg" HeaderText="Employee #">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="FALSE" DataField="Setflg" HeaderText="Employee #">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</form>
	</body>
</HTML>
