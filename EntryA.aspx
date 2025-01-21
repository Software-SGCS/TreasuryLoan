<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EntryA.aspx.vb" Inherits="TreasuryLoan.EntryA1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Entry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="lightblue" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 101; LEFT: 32px; POSITION: absolute; TOP: 72px" runat="server"
				Height="16px" Width="104px">Laon No</asp:label><asp:button id="BtnSave" style="Z-INDEX: 114; LEFT: 200px; POSITION: absolute; TOP: 568px" runat="server"
				Width="64px" Text="Save"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 113; LEFT: 112px; POSITION: absolute; TOP: 568px" runat="server"
				Width="64px" Text="Edit" Visible="False"></asp:button><asp:imagebutton id="btt1" style="Z-INDEX: 111; LEFT: 368px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg" Visible="False"></asp:imagebutton><asp:calendar id="Calendar1" style="Z-INDEX: 110; LEFT: 392px; POSITION: absolute; TOP: 72px"
				runat="server" Height="128px" Width="152px" BackColor="White" BorderColor="#3366CC" ForeColor="#003399" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px" DayNameFormat="FirstLetter"
				CellPadding="1" Visible="False">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:label id="Label11" style="Z-INDEX: 108; LEFT: 240px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="41px"> Date</asp:label><asp:panel id="Panel4" style="Z-INDEX: 106; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
				Height="626px" Width="8px" BackColor="Desktop"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 104; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="72px" Width="744px" BackColor="Desktop" BorderColor="Transparent" ForeColor="White" BackImageUrl="Menu/banner.jpg" Font-Bold="True" HorizontalAlign="Left"
				Enabled="False"><FONT style="BACKGROUND-COLOR: #000066">
					<DIV id="Layer1" style="Z-INDEX: 101; LEFT: 32px; OVERFLOW: scroll; WIDTH: 696px; POSITION: absolute; TOP: 456px; HEIGHT: 104px">
						<asp:datagrid id="Datagrid1" runat="server" Width="664px" Height="12px" BorderWidth="1px" Font-Size="12pt"
							Font-Names="Tahoma" BorderColor="CornflowerBlue" BackColor="White" cellpadding="3" Headerstyle-BackColor="#8080C0"
							Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma"
							AutogenerateColumns="False" BorderStyle="None">
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<EditItemStyle Font-Size="Smaller"></EditItemStyle>
							<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
							<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
							<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="L_No" HeaderText="Loan No">
									<HeaderStyle Width="1in"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="L_Adt" HeaderText="Amend Date">
									<HeaderStyle Width="0.9in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="L_ANo" HeaderText="Amendmend No">
									<HeaderStyle Width="1in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="L_PNoDys" HeaderText="Previus No Days">
									<HeaderStyle Width="1in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="L_CNoDys" HeaderText="Change No Days">
									<HeaderStyle Width="1in"></HeaderStyle>
									<ItemStyle HorizontalAlign="right"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></DIV>
					<asp:textbox id="TxtRNodys" style="Z-INDEX: 131; LEFT: 216px; POSITION: absolute; TOP: 168px"
						tabIndex="7" runat="server" Width="56px" Visible="False" AutoPostBack="True"></asp:textbox></FONT>
			</asp:panel><asp:panel id="Panel6" style="Z-INDEX: 103; LEFT: 744px; POSITION: absolute; TOP: -112px" runat="server"
				Height="802px" Width="16px" BackColor="Desktop"></asp:panel><asp:label id="Label2" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 168px" runat="server"
				Height="24px" Width="112px">Periods(In Days)</asp:label><asp:textbox id="TxtRefno" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="72px"></asp:textbox><asp:panel id="Panel3" style="Z-INDEX: 107; LEFT: 760px; POSITION: absolute; TOP: 0px" runat="server"
				Height="690px" Width="139px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel><asp:textbox id="TxtCrdDt" style="Z-INDEX: 109; LEFT: 296px; POSITION: absolute; TOP: 72px" tabIndex="2"
				runat="server" Height="24px" Width="72px" ReadOnly="True"></asp:textbox><asp:button id="BtnAdd" style="Z-INDEX: 112; LEFT: 32px; POSITION: absolute; TOP: 568px" runat="server"
				Width="64px" Text="Add"></asp:button><asp:dropdownlist id="LstLNam" style="Z-INDEX: 115; LEFT: 144px; POSITION: absolute; TOP: 96px" tabIndex="3"
				runat="server" Height="24px" Width="336px" AutoPostBack="True" Enabled="False"></asp:dropdownlist><asp:dropdownlist id="Lstcncy1" style="Z-INDEX: 116; LEFT: 144px; POSITION: absolute; TOP: 120px"
				tabIndex="4" runat="server" Height="24px" Width="64px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstFlg3" style="Z-INDEX: 117; LEFT: 144px; POSITION: absolute; TOP: 224px" tabIndex="9"
				runat="server" Height="16px" Width="64px" AutoPostBack="True" Enabled="False"></asp:dropdownlist><asp:dropdownlist id="LstFlg4" style="Z-INDEX: 118; LEFT: 688px; POSITION: absolute; TOP: 104px" runat="server"
				Height="16px" Width="39px" Visible="False"></asp:dropdownlist><asp:label id="Label14" style="Z-INDEX: 119; LEFT: 32px; POSITION: absolute; TOP: 96px" runat="server"
				Height="24px" Width="104px"> Lender Name</asp:label><asp:label id="Label15" style="Z-INDEX: 120; LEFT: 32px; POSITION: absolute; TOP: 120px" runat="server"
				Height="24px" Width="104px"> Currency</asp:label><asp:label id="Label16" style="Z-INDEX: 121; LEFT: 216px; POSITION: absolute; TOP: 120px" runat="server"
				Height="16px" Width="104px">Exchange Rate</asp:label><asp:dropdownlist id="LstRefno" style="Z-INDEX: 122; LEFT: 144px; POSITION: absolute; TOP: 72px" tabIndex="1"
				runat="server" Height="24px" Width="72px" AutoPostBack="True"></asp:dropdownlist><asp:label id="labelStatus" style="Z-INDEX: 123; LEFT: 272px; POSITION: absolute; TOP: 568px"
				runat="server" Height="18px" Width="112px"></asp:label><asp:label id="Label18" style="Z-INDEX: 124; LEFT: 32px; POSITION: absolute; TOP: 144px" runat="server"
				Height="24px" Width="104px">Loan Amount</asp:label><asp:textbox id="TxtMsg1" style="Z-INDEX: 125; LEFT: 144px; POSITION: absolute; TOP: 256px" tabIndex="10"
				runat="server" Height="40px" Width="585px" TextMode="MultiLine" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstMsg1" style="Z-INDEX: 126; LEFT: 560px; POSITION: absolute; TOP: 112px" runat="server"
				Height="24px" Width="62px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:label id="Label19" style="Z-INDEX: 127; LEFT: 32px; POSITION: absolute; TOP: 264px" runat="server"
				Height="24px" Width="113px"> Lender Note</asp:label><asp:textbox id="TxtMsg2" style="Z-INDEX: 128; LEFT: 144px; POSITION: absolute; TOP: 392px" tabIndex="14"
				runat="server" Height="56px" Width="585px" TextMode="MultiLine"></asp:textbox><asp:textbox id="TxtERate" style="Z-INDEX: 129; LEFT: 312px; POSITION: absolute; TOP: 120px"
				tabIndex="5" runat="server" Width="64px" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtCrdAmt" style="Z-INDEX: 130; LEFT: 144px; POSITION: absolute; TOP: 144px"
				tabIndex="6" runat="server" Width="96px" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:textbox id="TxtNodys" style="Z-INDEX: 131; LEFT: 144px; POSITION: absolute; TOP: 168px"
				tabIndex="7" runat="server" Width="56px" AutoPostBack="True"></asp:textbox><asp:label id="Label20" style="Z-INDEX: 132; LEFT: 592px; POSITION: absolute; TOP: 320px" runat="server"
				Height="24px" Width="90px">Int Rate (p.a):-</asp:label><asp:dropdownlist id="Lstmsg2" style="Z-INDEX: 133; LEFT: 640px; POSITION: absolute; TOP: 112px" runat="server"
				Height="24px" Width="54px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:label id="Label21" style="Z-INDEX: 134; LEFT: 32px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Width="120px">Debit Invoice No:-</asp:label><asp:label id="Label22" style="Z-INDEX: 135; LEFT: 200px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Width="32px">Date:-</asp:label><asp:label id="Label23" style="Z-INDEX: 136; LEFT: 320px; POSITION: absolute; TOP: 320px" runat="server"
				Height="24px" Width="64px"> Currency:-</asp:label><asp:label id="Label24" style="Z-INDEX: 137; LEFT: 424px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Width="100px">Exchange Rate:-</asp:label><asp:label id="Label25" style="Z-INDEX: 138; LEFT: 32px; POSITION: absolute; TOP: 344px" runat="server"
				Height="24px" Width="112px">Periods(In Days):-</asp:label><asp:label id="lbl1" style="Z-INDEX: 139; LEFT: 192px; POSITION: absolute; TOP: 344px" runat="server"
				Height="24px" Width="96px">Maturity Date:-</asp:label><asp:label id="Label28" style="Z-INDEX: 140; LEFT: 376px; POSITION: absolute; TOP: 344px" runat="server"
				Height="24px" Width="112px">Maturity Interest:-</asp:label><asp:label id="Label29" style="Z-INDEX: 141; LEFT: 560px; POSITION: absolute; TOP: 344px" runat="server"
				Height="24px" Width="48px">Total:-</asp:label><asp:label id="Label30" style="Z-INDEX: 142; LEFT: 32px; POSITION: absolute; TOP: 192px" runat="server"
				Height="24px" Width="112px">Interst Rate (p.a)</asp:label><asp:label id="Label31" style="Z-INDEX: 143; LEFT: 32px; POSITION: absolute; TOP: 392px" runat="server"
				Height="24px" Width="113px"> Borrower Note</asp:label><asp:textbox id="TxtIndentnO" style="Z-INDEX: 144; LEFT: 720px; POSITION: absolute; TOP: 112px"
				runat="server" Width="14px" Visible="False"></asp:textbox><asp:textbox id="TxtIntRate" style="Z-INDEX: 145; LEFT: 144px; POSITION: absolute; TOP: 192px"
				tabIndex="8" runat="server" Width="56px" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="LblDbtInv" style="Z-INDEX: 146; LEFT: 144px; POSITION: absolute; TOP: 320px"
				runat="server" Height="24px" Width="64px" ForeColor="Blue"></asp:label><asp:label id="LblDbtDt" style="Z-INDEX: 147; LEFT: 248px; POSITION: absolute; TOP: 320px"
				runat="server" Height="16px" Width="72px" ForeColor="Blue"></asp:label><asp:label id="Label26" style="Z-INDEX: 148; LEFT: 32px; POSITION: absolute; TOP: 368px" runat="server"
				Height="24px" Width="112px">Borrower Name</asp:label><asp:dropdownlist id="LstBName" style="Z-INDEX: 149; LEFT: 144px; POSITION: absolute; TOP: 368px"
				tabIndex="12" runat="server" Height="24px" Width="345px" AutoPostBack="True" Enabled="False"></asp:dropdownlist><asp:label id="LblCncy" style="Z-INDEX: 150; LEFT: 384px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Width="56px" ForeColor="Blue"></asp:label><asp:label id="LblERate" style="Z-INDEX: 151; LEFT: 528px; POSITION: absolute; TOP: 320px"
				runat="server" Height="16px" Width="56px" ForeColor="Blue"></asp:label><asp:label id="Label32" style="Z-INDEX: 152; LEFT: 280px; POSITION: absolute; TOP: 152px" runat="server"
				Height="16px" Width="88px"> Maturity Date</asp:label><asp:label id="Label33" style="Z-INDEX: 153; LEFT: 280px; POSITION: absolute; TOP: 176px" runat="server"
				Height="16px" Width="88px"> Maturity Int</asp:label><asp:label id="Label34" style="Z-INDEX: 154; LEFT: 488px; POSITION: absolute; TOP: 200px" runat="server"
				Height="24px" Width="96px"> Repayment</asp:label><asp:label id="Label35" style="Z-INDEX: 155; LEFT: 384px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Width="88px" ForeColor="Blue"></asp:label><asp:label id="Label36" style="Z-INDEX: 156; LEFT: 384px; POSITION: absolute; TOP: 176px" runat="server"
				Height="16px" Width="88px" ForeColor="Blue"></asp:label><asp:label id="Label37" style="Z-INDEX: 157; LEFT: 632px; POSITION: absolute; TOP: 200px" runat="server"
				Height="16px" Width="112px" ForeColor="Blue"></asp:label><asp:label id="LblNoDys" style="Z-INDEX: 158; LEFT: 144px; POSITION: absolute; TOP: 344px"
				runat="server" Height="24px" Width="64px" ForeColor="Blue"></asp:label><asp:label id="LblCrdDt" style="Z-INDEX: 159; LEFT: 304px; POSITION: absolute; TOP: 344px"
				runat="server" Width="57px" ForeColor="Blue"></asp:label><asp:label id="LblInt" style="Z-INDEX: 160; LEFT: 488px; POSITION: absolute; TOP: 344px" runat="server"
				Height="16px" Width="72px" ForeColor="Blue"></asp:label><asp:label id="LblRate" style="Z-INDEX: 161; LEFT: 680px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Width="16px" ForeColor="Blue"></asp:label><asp:label id="Lbltot" style="Z-INDEX: 162; LEFT: 616px; POSITION: absolute; TOP: 344px" runat="server"
				Height="8px" Width="104px" ForeColor="Blue"></asp:label><asp:panel id="Panel5" style="Z-INDEX: 163; LEFT: 8px; POSITION: absolute; TOP: 296px" runat="server"
				Height="16px" Width="736px" BackColor="Desktop"></asp:panel><asp:label id="Label27" style="Z-INDEX: 164; LEFT: 32px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="96px">Debit Tax</asp:label><asp:textbox id="TxtRtg" style="Z-INDEX: 165; LEFT: 600px; POSITION: absolute; TOP: 112px" runat="server"
				Height="24px" Width="32px" AutoPostBack="True" Visible="False"></asp:textbox><asp:label id="Label39" style="Z-INDEX: 166; LEFT: 280px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="144px">Fund Transfer Chargers</asp:label><asp:textbox id="TxtFndVal" style="Z-INDEX: 167; LEFT: 456px; POSITION: absolute; TOP: 224px"
				tabIndex="11" runat="server" Height="24px" Width="88px" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="LblDVal" style="Z-INDEX: 168; LEFT: 384px; POSITION: absolute; TOP: 200px" runat="server"
				Height="24px" Width="88px" ForeColor="Blue"></asp:label><asp:label id="LblRtgsVal" style="Z-INDEX: 169; LEFT: 488px; POSITION: absolute; TOP: 152px"
				runat="server" Height="24px" Width="136px"></asp:label><asp:label id="LblFudTra" style="Z-INDEX: 170; LEFT: 488px; POSITION: absolute; TOP: 176px"
				runat="server" Height="24px" Width="136px"></asp:label><asp:label id="LblRval" style="Z-INDEX: 171; LEFT: 632px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Width="104px" ForeColor="Blue"></asp:label><asp:label id="LblFVal" style="Z-INDEX: 172; LEFT: 632px; POSITION: absolute; TOP: 176px" runat="server"
				Height="24px" Width="104px" ForeColor="Blue"></asp:label><asp:label id="LblDbTax" style="Z-INDEX: 173; LEFT: 280px; POSITION: absolute; TOP: 200px"
				runat="server" Height="24px" Width="96px"></asp:label><asp:panel id="Panel2" style="Z-INDEX: 174; LEFT: 8px; POSITION: absolute; TOP: 600px" runat="server"
				Height="88px" Width="736px" BackColor="Desktop"></asp:panel><asp:textbox id="val1" style="Z-INDEX: 175; LEFT: 560px; POSITION: absolute; TOP: 104px" runat="server"
				Height="26px" Width="40px" Visible="False"></asp:textbox><asp:textbox id="val2" style="Z-INDEX: 176; LEFT: 608px; POSITION: absolute; TOP: 104px" runat="server"
				Height="26px" Width="40px" Visible="False"></asp:textbox><asp:textbox id="Val3" style="Z-INDEX: 177; LEFT: 656px; POSITION: absolute; TOP: 104px" runat="server"
				Height="26px" Width="40px" Visible="False"></asp:textbox><asp:textbox id="val4" style="Z-INDEX: 178; LEFT: 704px; POSITION: absolute; TOP: 104px" runat="server"
				Height="26px" Width="40px" Visible="False"></asp:textbox><asp:textbox id="TxtFlg1" style="Z-INDEX: 179; LEFT: 656px; POSITION: absolute; TOP: 568px" runat="server"
				Width="64px" Visible="False"></asp:textbox><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" style="Z-INDEX: 180; LEFT: 400px; POSITION: absolute; TOP: 624px"
				runat="server" Height="50px" Width="350px" Visible="False"></CR:CRYSTALREPORTVIEWER><asp:imagebutton id="BtnCreInv" style="Z-INDEX: 181; LEFT: 360px; POSITION: absolute; TOP: 564px"
				runat="server" Height="32px" Width="112px" ImageUrl="Menu\ICON1.JPG"></asp:imagebutton><asp:imagebutton id="BtnDbtInv" style="Z-INDEX: 182; LEFT: 480px; POSITION: absolute; TOP: 564px"
				runat="server" Height="32px" Width="112px" ImageUrl="Menu\ICON2.JPG"></asp:imagebutton>
			<asp:Label id="l1" style="Z-INDEX: 183; LEFT: 624px; POSITION: absolute; TOP: 568px" runat="server"
				Height="24px" Width="105px"></asp:Label>
			<asp:TextBox id="TxtRMsg2" style="Z-INDEX: 184; LEFT: 496px; POSITION: absolute; TOP: 368px"
				runat="server" Width="232px" Height="16px" Visible="False" TextMode="MultiLine"></asp:TextBox>
			<asp:TextBox id="TxtAnO" style="Z-INDEX: 185; LEFT: 616px; POSITION: absolute; TOP: 232px" runat="server"
				Width="88px" Visible="False"></asp:TextBox></form>
	</body>
</HTML>
