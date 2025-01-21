<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Dispaly11.aspx.vb" Inherits="TreasuryLoan.Dispaly1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Dispaly1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel5" style="Z-INDEX: 105; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="744px" Height="72px" BackImageUrl="Menu/BANNER.jpg" Font-Names="Tahoma">
				<DIV id="Div1" style="Z-INDEX: 100; LEFT: 24px; OVERFLOW: scroll; WIDTH: 432px; POSITION: absolute; TOP: 120px; HEIGHT: 128px"
					noWrap>
					<asp:datagrid id="Datagrid1" runat="server" Font-Names="Tahoma" Height="12px" Width="408px" BorderWidth="1px"
						Font-Size="Small" BorderStyle="None" DataKeyField="id" AutogenerateColumns="False" Font-Name="Tahoma"
						Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
						cellpadding="3" BorderColor="#CCCCCC" BackColor="White">
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<EditItemStyle Font-Size="Smaller"></EditItemStyle>
						<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
						<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<Columns>
							<asp:BoundColumn DataField="Mas_Refno" HeaderText="Ref No">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndRcdt" HeaderText="Received ">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndNos" HeaderText="Indent Nos">
								<HeaderStyle Width="4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></DIV>
				<asp:panel id="Panel4" style="Z-INDEX: 110; LEFT: 0px; POSITION: absolute; TOP: 8px" runat="server"
					Height="608px" Width="16px" BackColor="Desktop"></asp:panel>
				<asp:label id="Label7" style="Z-INDEX: 108; LEFT: 464px; POSITION: absolute; TOP: 96px" runat="server"
					Font-Names="Tahoma" Height="24px" Width="240px">Incomplete Indents(s) </asp:label>
				<DIV id="Div5" style="Z-INDEX: 107; LEFT: 464px; OVERFLOW: scroll; WIDTH: 428px; POSITION: absolute; TOP: 120px; HEIGHT: 120px"
					noWrap>
					<asp:datagrid id="Datagrid6" runat="server" Font-Names="Tahoma" Height="12px" Width="400px" BorderWidth="1px"
						Font-Size="Small" BorderStyle="None" DataKeyField="id" AutogenerateColumns="False" Font-Name="Tahoma"
						Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
						cellpadding="3" BorderColor="#CCCCCC" BackColor="White">
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<EditItemStyle Font-Size="Smaller"></EditItemStyle>
						<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
						<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<Columns>
							<asp:BoundColumn DataField="Mas_Refno" HeaderText="Ref No">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndRcdt" HeaderText="Received ">
								<HeaderStyle Width="1in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndNos" HeaderText="Indent Nos">
								<HeaderStyle Width="4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_Msg" HeaderText="Msg">
								<HeaderStyle Width="4in"></HeaderStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></DIV>
				<DIV id="Div4" style="Z-INDEX: 106; LEFT: 24px; OVERFLOW: scroll; WIDTH: 432px; POSITION: absolute; TOP: 424px; HEIGHT: 128px"
					noWrap>
					<asp:datagrid id="Datagrid5" style="LEFT: 0px; TOP: -8px" runat="server" Font-Names="Tahoma" Height="12px"
						Width="408px" BorderWidth="1px" Font-Size="Small" BorderStyle="None" DataKeyField="id" AutogenerateColumns="False"
						Font-Name="Tahoma" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma"
						Headerstyle-BackColor="#8080C0" cellpadding="3" BorderColor="#CCCCCC" BackColor="White">
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<EditItemStyle Font-Size="Smaller"></EditItemStyle>
						<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
						<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<Columns>
							<asp:BoundColumn DataField="Mas_Refno" HeaderText="Ref No">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndRcdt" HeaderText="Received ">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndNos" HeaderText="Indent Nos">
								<HeaderStyle Width="4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></DIV>
				<asp:label id="Label6" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 400px" runat="server"
					Font-Names="Tahoma" Height="24px" Width="240px">Pending-Approval</asp:label>
				<asp:label id="Label5" style="Z-INDEX: 104; LEFT: 464px; POSITION: absolute; TOP: 240px" runat="server"
					Font-Names="Tahoma" Height="24px" Width="240px">Pending-License</asp:label>
				<DIV id="Div3" style="Z-INDEX: 103; LEFT: 464px; OVERFLOW: scroll; WIDTH: 432px; POSITION: absolute; TOP: 264px; HEIGHT: 136px"
					noWrap>
					<asp:datagrid id="Datagrid4" runat="server" Font-Names="Tahoma" Height="12px" Width="408px" BorderWidth="1px"
						Font-Size="Small" BorderStyle="None" DataKeyField="id" AutogenerateColumns="False" Font-Name="Tahoma"
						Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
						cellpadding="3" BorderColor="#CCCCCC" BackColor="White">
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<EditItemStyle Font-Size="Smaller"></EditItemStyle>
						<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
						<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<Columns>
							<asp:BoundColumn DataField="Mas_Refno" HeaderText="Ref No">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndRcdt" HeaderText="Received ">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndNos" HeaderText="Indent Nos">
								<HeaderStyle Width="4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></DIV>
				<asp:label id="Label4" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 248px" runat="server"
					Font-Names="Tahoma" Height="24px" Width="240px">Pending-Insurance</asp:label>
				<DIV id="Div2" style="Z-INDEX: 101; LEFT: 24px; OVERFLOW: scroll; WIDTH: 432px; POSITION: absolute; TOP: 272px; HEIGHT: 128px"
					noWrap>
					<asp:datagrid id="Datagrid3" runat="server" Font-Names="Tahoma" Height="12px" Width="408px" BorderWidth="1px"
						Font-Size="Small" BorderStyle="None" DataKeyField="id" AutogenerateColumns="False" Font-Name="Tahoma"
						Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
						cellpadding="3" BorderColor="#CCCCCC" BackColor="White">
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<EditItemStyle Font-Size="Smaller"></EditItemStyle>
						<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
						<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<Columns>
							<asp:BoundColumn DataField="Mas_Refno" HeaderText="Ref No">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndRcdt" HeaderText="Received ">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndNos" HeaderText="Indent Nos">
								<HeaderStyle Width="4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></DIV>
				<DIV id="Div6" style="Z-INDEX: 111; LEFT: 464px; OVERFLOW: scroll; WIDTH: 432px; POSITION: absolute; TOP: 424px; HEIGHT: 128px"
					noWrap>
					<asp:datagrid id="Datagrid7" runat="server" Font-Names="Tahoma" Height="12px" Width="408px" BorderWidth="1px"
						Font-Size="Small" BorderStyle="None" DataKeyField="id" AutogenerateColumns="False" Font-Name="Tahoma"
						Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
						cellpadding="3" BorderColor="#CCCCCC" BackColor="White">
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<EditItemStyle Font-Size="Smaller"></EditItemStyle>
						<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
						<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<Columns>
							<asp:BoundColumn DataField="Mas_InTrm" HeaderText="Type"></asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_Refno" HeaderText="Ref No">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndRcdt" HeaderText="Received ">
								<HeaderStyle Width="1.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Mas_IndNos" HeaderText="Indent Nos">
								<HeaderStyle Width="4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></DIV>
				<asp:label id="Label8" style="Z-INDEX: 112; LEFT: 464px; POSITION: absolute; TOP: 400px" runat="server"
					Height="24px" Width="240px">Pending-L/C  T/T  B/D</asp:label>
				<asp:panel id="Panel2" style="Z-INDEX: 113; LEFT: 16px; POSITION: absolute; TOP: 552px" runat="server"
					BackImageUrl="Menu/EmpMaster3.jpg" Height="64px" Width="904px" BackColor="Desktop"></asp:panel>
			</asp:panel><asp:label id="Label1" style="Z-INDEX: 101; LEFT: -16px; POSITION: absolute; TOP: 72px" runat="server"
				Width="958px" Height="8px" BackColor="Black">Label</asp:label><asp:panel id="Panel9" style="Z-INDEX: 104; LEFT: 746px; POSITION: absolute; TOP: 0px" runat="server"
				Width="196px" Height="72px" BackImageUrl="Menu/BANN1.jpg"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 103; LEFT: 920px; POSITION: absolute; TOP: 8px" runat="server"
				Width="112px" Height="607px" BackImageUrl="Menu/EmpMaster4.jpg" BackColor="Desktop"></asp:panel><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 312px; POSITION: absolute; TOP: 96px" runat="server"
				Width="88px" Height="24px"></asp:label><asp:textbox id="TxtId" style="Z-INDEX: 107; LEFT: 416px; POSITION: absolute; TOP: 96px" runat="server"
				Width="32px" Visible="False"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 108; LEFT: 24px; POSITION: absolute; TOP: 96px" runat="server"
				Width="240px" Height="24px" Font-Names="Tahoma">Pending  Indent(S)</asp:label></form>
	</body>
</HTML>
