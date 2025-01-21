<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EntrySettlemn.aspx.vb" Inherits="TreasuryLoan.EntrySettlemn" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Entry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffff" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:button id="BtnSave" style="Z-INDEX: 112; LEFT: 200px; POSITION: absolute; TOP: 568px" runat="server"
				Width="64px" Text="Save"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 111; LEFT: 112px; POSITION: absolute; TOP: 568px" runat="server"
				Width="64px" Text="Edit"></asp:button><asp:imagebutton id="btt1" style="Z-INDEX: 108; LEFT: 304px; POSITION: absolute; TOP: 96px" runat="server"
				Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar1" style="Z-INDEX: 107; LEFT: 328px; POSITION: absolute; TOP: 96px"
				runat="server" Font-Names="Times New Roman" Width="160px" Height="136px" NextPrevFormat="FullMonth" TitleFormat="Month" DayNameFormat="FirstLetter" Font-Size="10pt"
				ForeColor="Black" BorderColor="Black" BackColor="White">
				<TodayDayStyle BackColor="#CCCC99"></TodayDayStyle>
				<SelectorStyle Font-Size="8pt" Font-Names="Verdana" Font-Bold="True" ForeColor="#333333" Width="1%"
					BackColor="#CCCCCC"></SelectorStyle>
				<DayStyle Width="14%"></DayStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="White"></NextPrevStyle>
				<DayHeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" Height="10px" ForeColor="#333333"
					BackColor="#CCCCCC"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#CC3333"></SelectedDayStyle>
				<TitleStyle Font-Size="13pt" Font-Bold="True" Height="14pt" ForeColor="White" BackColor="Black"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:label id="Label11" style="Z-INDEX: 105; LEFT: 56px; POSITION: absolute; TOP: 96px" runat="server"
				Font-Names="Calibri" Width="112px" Height="24px"> EFFECTIVE DATE</asp:label><asp:panel id="Panel4" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
				Width="8px" Height="626px" BackColor="Desktop"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: -8px" runat="server"
				Width="736px" Height="72px" ForeColor="White" BorderColor="Transparent" BackColor="Desktop" Enabled="False" HorizontalAlign="Left" Font-Bold="True" BackImageUrl="Menu/banner.jpg"><FONT style="BACKGROUND-COLOR: #000066">
					<DIV id="Layer1" style="Z-INDEX: 101; LEFT: 32px; OVERFLOW: scroll; WIDTH: 384px; POSITION: absolute; TOP: 456px; HEIGHT: 104px">
						<asp:datagrid id="Datagrid1" runat="server" Width="360px" Height="12px" BackColor="White" BorderColor="CornflowerBlue"
							Font-Size="12pt" Font-Names="Calibri" BorderWidth="1px" cellpadding="3" Headerstyle-BackColor="#8080C0"
							Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma"
							AutogenerateColumns="False" BorderStyle="None">
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<EditItemStyle Font-Size="Smaller"></EditItemStyle>
							<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
							<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
							<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="LiDate" HeaderText="Loan Date">
									<HeaderStyle Width="1in"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="LiNo" HeaderText="Loan No">
									<HeaderStyle Width="0.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="BrName" HeaderText="Borrower Name">
									<HeaderStyle Width="3.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="LiCur" HeaderText="Currency">
									<HeaderStyle Width="0.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="LiAmt" HeaderText="Laon Amount">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></DIV>
					<asp:button id="Button3" style="Z-INDEX: 187; LEFT: 576px; POSITION: absolute; TOP: 488px" runat="server"
						Text="PENDING   DEBIT INVOICES" Width="306px" Height="24px" BackColor="#C0FFFF" BorderColor="Olive"
						Font-Names="Calibri"></asp:button>
					<asp:Image id="Image2" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 328px" runat="server"
						Width="898px" Height="8px" BackColor="Desktop"></asp:Image>
					<DIV id="Div1" style="Z-INDEX: 102; LEFT: 488px; OVERFLOW: scroll; WIDTH: 400px; POSITION: absolute; TOP: 456px; HEIGHT: 104px">
						<asp:datagrid id="Datagrid2" runat="server" Width="360px" Height="12px" BackColor="White" BorderColor="CornflowerBlue"
							Font-Size="12pt" Font-Names="Calibri" BorderWidth="1px" cellpadding="3" Headerstyle-BackColor="#8080C0"
							Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma"
							AutogenerateColumns="False" BorderStyle="None">
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<EditItemStyle Font-Size="Smaller"></EditItemStyle>
							<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
							<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
							<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="LiDate" HeaderText="Loan Date">
									<HeaderStyle Width="1in"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="LiNo" HeaderText="Loan No">
									<HeaderStyle Width="0.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="BrName" HeaderText="Borrower Name">
									<HeaderStyle Width="3.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="LiCur" HeaderText="Currency">
									<HeaderStyle Width="0.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="LiAmt" HeaderText="Laon Amount">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></DIV>
				</FONT>
			</asp:panel><asp:label id="Label2" style="Z-INDEX: 100; LEFT: 344px; POSITION: absolute; TOP: 96px" runat="server"
				Font-Names="Calibri" Width="112px" Height="24px"> PERIOD</asp:label><asp:textbox id="TxtRefno" style="Z-INDEX: 102; LEFT: 544px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Names="Calibri" Width="72px" Height="24px" Font-Size="Small"></asp:textbox><asp:panel id="Panel3" style="Z-INDEX: 104; LEFT: 904px; POSITION: absolute; TOP: 0px" runat="server"
				Width="11px" Height="690px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel><asp:textbox id="TxtCrdDt" style="Z-INDEX: 106; LEFT: 216px; POSITION: absolute; TOP: 96px" tabIndex="2"
				runat="server" Font-Names="Calibri" Width="80px" Height="24px" Font-Size="Small" ReadOnly="True"></asp:textbox><asp:button id="BtnAdd" style="Z-INDEX: 109; LEFT: 32px; POSITION: absolute; TOP: 568px" runat="server"
				Width="64px" Text="Add" Visible="False"></asp:button><asp:dropdownlist id="LstLNam" style="Z-INDEX: 113; LEFT: 136px; POSITION: absolute; TOP: 344px" tabIndex="3"
				runat="server" Font-Names="Calibri" Width="296px" Height="24px" Font-Size="Small" AutoPostBack="True" Enabled="False"></asp:dropdownlist><asp:dropdownlist id="Lstcncy1" style="Z-INDEX: 114; LEFT: 824px; POSITION: absolute; TOP: 96px" tabIndex="4"
				runat="server" Font-Names="Calibri" Width="64px" Height="24px" Font-Size="Small" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstFlg3" style="Z-INDEX: 115; LEFT: 760px; POSITION: absolute; TOP: 184px" tabIndex="9"
				runat="server" Font-Names="Calibri" Width="72px" Height="16px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:dropdownlist id="LstFlg4" style="Z-INDEX: 116; LEFT: 688px; POSITION: absolute; TOP: 104px" runat="server"
				Width="39px" Height="16px" Visible="False"></asp:dropdownlist><asp:label id="Label14" style="Z-INDEX: 117; LEFT: 16px; POSITION: absolute; TOP: 344px" runat="server"
				Font-Names="Calibri" Width="104px" Height="24px"> LENDER NAME</asp:label><asp:label id="Label15" style="Z-INDEX: 118; LEFT: 704px; POSITION: absolute; TOP: 96px" runat="server"
				Font-Names="Calibri" Width="104px" Height="24px"> CURRENCY</asp:label><asp:label id="Label16" style="Z-INDEX: 119; LEFT: 704px; POSITION: absolute; TOP: 120px" runat="server"
				Font-Names="Calibri" Width="120px" Height="16px">EXCHANGE RATE</asp:label><asp:label id="labelStatus" style="Z-INDEX: 120; LEFT: 272px; POSITION: absolute; TOP: 568px"
				runat="server" Width="112px" Height="18px"></asp:label><asp:label id="Label18" style="Z-INDEX: 121; LEFT: 56px; POSITION: absolute; TOP: 232px" runat="server"
				Font-Names="Calibri" Width="112px" Height="24px">LOAN AMOUNT</asp:label><asp:textbox id="TxtMsg1" style="Z-INDEX: 122; LEFT: 136px; POSITION: absolute; TOP: 376px" tabIndex="10"
				runat="server" Font-Names="Calibri" Width="294px" Height="102px" Font-Size="Small" TextMode="MultiLine" Enabled="False"></asp:textbox><asp:dropdownlist id="LstMsg1" style="Z-INDEX: 123; LEFT: 560px; POSITION: absolute; TOP: 112px" runat="server"
				Width="62px" Height="24px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:label id="Label19" style="Z-INDEX: 124; LEFT: 16px; POSITION: absolute; TOP: 384px" runat="server"
				Font-Names="Calibri" Width="113px" Height="24px"> NOTE</asp:label><asp:textbox id="TxtMsg2" style="Z-INDEX: 125; LEFT: 576px; POSITION: absolute; TOP: 376px" tabIndex="14"
				runat="server" Font-Names="Calibri" Width="298px" Height="102px" Font-Size="Small" TextMode="MultiLine" ReadOnly="True"></asp:textbox><asp:textbox id="TxtERate" style="Z-INDEX: 126; LEFT: 824px; POSITION: absolute; TOP: 120px"
				tabIndex="5" runat="server" Font-Names="Calibri" Width="64px" Font-Size="Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtCrdAmt" style="Z-INDEX: 127; LEFT: 216px; POSITION: absolute; TOP: 232px"
				tabIndex="6" runat="server" Font-Names="Calibri" Width="96px" Font-Size="Small" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:textbox id="TxtNodys" style="Z-INDEX: 128; LEFT: 464px; POSITION: absolute; TOP: 96px" tabIndex="7"
				runat="server" Font-Names="Calibri" Width="49px" Font-Size="Small" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="Label20" style="Z-INDEX: 129; LEFT: 480px; POSITION: absolute; TOP: 280px" runat="server"
				Width="90px" Height="24px" Font-Bold="True" Visible="False">Int Rate (p.a):-</asp:label><asp:dropdownlist id="Lstmsg2" style="Z-INDEX: 130; LEFT: 640px; POSITION: absolute; TOP: 112px" runat="server"
				Width="54px" Height="24px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:label id="Label21" style="Z-INDEX: 131; LEFT: 552px; POSITION: absolute; TOP: 224px" runat="server"
				Width="120px" Height="16px" Font-Bold="True" Visible="False">Debit Invoice No:-</asp:label><asp:label id="Label22" style="Z-INDEX: 132; LEFT: 328px; POSITION: absolute; TOP: 256px" runat="server"
				Width="32px" Height="16px" Font-Bold="True" Visible="False">Date:-</asp:label><asp:label id="Label23" style="Z-INDEX: 133; LEFT: 400px; POSITION: absolute; TOP: 256px" runat="server"
				Width="64px" Height="24px" Font-Bold="True" Visible="False"> Currency:-</asp:label><asp:label id="Label24" style="Z-INDEX: 134; LEFT: 784px; POSITION: absolute; TOP: 232px" runat="server"
				Width="100px" Height="16px" Font-Bold="True" Visible="False">Exchange Rate:-</asp:label><asp:label id="Label25" style="Z-INDEX: 135; LEFT: 624px; POSITION: absolute; TOP: 344px" runat="server"
				Width="153px" Height="24px" Font-Bold="True" Visible="False">Periods(In Days):-</asp:label><asp:label id="lbl1" style="Z-INDEX: 136; LEFT: 520px; POSITION: absolute; TOP: 328px" runat="server"
				Width="96px" Height="24px" Font-Bold="True" Visible="False">Maturity Date:-</asp:label><asp:label id="Label28" style="Z-INDEX: 137; LEFT: 376px; POSITION: absolute; TOP: 312px" runat="server"
				Width="112px" Height="24px" Font-Bold="True" Visible="False">Maturity Interest:-</asp:label><asp:label id="Label29" style="Z-INDEX: 138; LEFT: 544px; POSITION: absolute; TOP: 304px" runat="server"
				Width="48px" Height="24px" Font-Bold="True" Visible="False">Total:-</asp:label><asp:label id="Label30" style="Z-INDEX: 139; LEFT: 384px; POSITION: absolute; TOP: 232px" runat="server"
				Font-Names="Calibri" Width="112px" Height="24px"> INTEREST RATE</asp:label><asp:label id="Label31" style="Z-INDEX: 140; LEFT: 440px; POSITION: absolute; TOP: 384px" runat="server"
				Font-Names="Calibri" Width="113px" Height="16px"> NOTE</asp:label><asp:textbox id="TxtIndentnO" style="Z-INDEX: 141; LEFT: 720px; POSITION: absolute; TOP: 112px"
				runat="server" Width="14px" Visible="False"></asp:textbox><asp:textbox id="TxtIntRate" style="Z-INDEX: 142; LEFT: 536px; POSITION: absolute; TOP: 232px"
				tabIndex="8" runat="server" Font-Names="Calibri" Width="49px" Font-Size="Small" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="LblDbtInv" style="Z-INDEX: 143; LEFT: 680px; POSITION: absolute; TOP: 224px"
				runat="server" Width="64px" Height="24px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="LblDbtDt" style="Z-INDEX: 144; LEFT: 376px; POSITION: absolute; TOP: 256px"
				runat="server" Width="72px" Height="16px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="Label26" style="Z-INDEX: 145; LEFT: 440px; POSITION: absolute; TOP: 344px" runat="server"
				Font-Names="Calibri" Width="144px" Height="24px">BORROWER NAME</asp:label><asp:dropdownlist id="LstBName" style="Z-INDEX: 146; LEFT: 576px; POSITION: absolute; TOP: 344px"
				tabIndex="12" runat="server" Font-Names="Calibri" Width="298px" Height="24px" Font-Size="Small" AutoPostBack="True" Enabled="False"></asp:dropdownlist><asp:label id="LblCncy" style="Z-INDEX: 147; LEFT: 480px; POSITION: absolute; TOP: 256px" runat="server"
				Width="56px" Height="16px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="LblERate" style="Z-INDEX: 148; LEFT: 384px; POSITION: absolute; TOP: 280px"
				runat="server" Width="56px" Height="16px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="Label32" style="Z-INDEX: 149; LEFT: 56px; POSITION: absolute; TOP: 120px" runat="server"
				Font-Names="Calibri" Width="112px" Height="16px"> MATURITY DATE</asp:label><asp:label id="Label33" style="Z-INDEX: 150; LEFT: 56px; POSITION: absolute; TOP: 264px" runat="server"
				Font-Names="Calibri" Width="144px" Height="16px"> MATURITY INTEREST</asp:label><asp:label id="Label34" style="Z-INDEX: 151; LEFT: 56px; POSITION: absolute; TOP: 296px" runat="server"
				Font-Names="Calibri" Width="144px" Height="24px"> MATURITY AMOUNT</asp:label><asp:label id="Label35" style="Z-INDEX: 152; LEFT: 216px; POSITION: absolute; TOP: 120px" runat="server"
				Font-Names="Calibri" Width="88px" Height="24px" Font-Size="Small" ForeColor="Black" BorderStyle="Groove"></asp:label><asp:label id="Label36" style="Z-INDEX: 153; LEFT: 216px; POSITION: absolute; TOP: 264px" runat="server"
				Font-Names="Calibri" Width="96px" Height="16px" Font-Size="Small" ForeColor="Black" BorderStyle="Groove"></asp:label><asp:label id="Label37" style="Z-INDEX: 154; LEFT: 216px; POSITION: absolute; TOP: 296px" runat="server"
				Font-Names="Calibri" Width="96px" Height="16px" ForeColor="Black" BorderStyle="Groove"></asp:label><asp:label id="LblNoDys" style="Z-INDEX: 155; LEFT: 776px; POSITION: absolute; TOP: 344px"
				runat="server" Width="64px" Height="24px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="LblCrdDt" style="Z-INDEX: 156; LEFT: 728px; POSITION: absolute; TOP: 296px"
				runat="server" Width="57px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="LblInt" style="Z-INDEX: 157; LEFT: 472px; POSITION: absolute; TOP: 304px" runat="server"
				Width="72px" Height="16px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="LblRate" style="Z-INDEX: 158; LEFT: 568px; POSITION: absolute; TOP: 280px" runat="server"
				Width="16px" Height="16px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="Lbltot" style="Z-INDEX: 159; LEFT: 600px; POSITION: absolute; TOP: 304px" runat="server"
				Width="104px" Height="8px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="Label27" style="Z-INDEX: 160; LEFT: 608px; POSITION: absolute; TOP: 304px" runat="server"
				Font-Names="Calibri" Width="96px" Height="24px">DT CHARGERS</asp:label><asp:textbox id="TxtRtg" style="Z-INDEX: 161; LEFT: 600px; POSITION: absolute; TOP: 112px" runat="server"
				Width="32px" Height="24px" AutoPostBack="True" Visible="False"></asp:textbox><asp:label id="Label39" style="Z-INDEX: 162; LEFT: 608px; POSITION: absolute; TOP: 272px" runat="server"
				Font-Names="Calibri" Width="136px" Height="24px">FT CHARGERS</asp:label><asp:textbox id="TxtFndVal" style="Z-INDEX: 163; LEFT: 752px; POSITION: absolute; TOP: 272px"
				tabIndex="11" runat="server" Font-Names="Calibri" Width="96px" Height="24px" Font-Size="Small" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="LblDVal" style="Z-INDEX: 164; LEFT: 528px; POSITION: absolute; TOP: 192px" runat="server"
				Width="104px" Height="24px" ForeColor="Black" BorderStyle="Groove" Visible="False"></asp:label><asp:label id="LblRtgsVal" style="Z-INDEX: 165; LEFT: 656px; POSITION: absolute; TOP: 272px"
				runat="server" Width="104px" Height="24px" Font-Bold="True"></asp:label><asp:label id="LblFudTra" style="Z-INDEX: 166; LEFT: 488px; POSITION: absolute; TOP: 176px"
				runat="server" Width="136px" Height="24px" Font-Bold="True" Visible="False"></asp:label><asp:label id="LblRval" style="Z-INDEX: 167; LEFT: 800px; POSITION: absolute; TOP: 272px" runat="server"
				Width="72px" Height="24px" ForeColor="Black"></asp:label><asp:label id="LblFVal" style="Z-INDEX: 168; LEFT: 632px; POSITION: absolute; TOP: 176px" runat="server"
				Width="104px" Height="24px" ForeColor="Black" Visible="False"></asp:label><asp:label id="LblDbTax" style="Z-INDEX: 169; LEFT: 424px; POSITION: absolute; TOP: 192px"
				runat="server" Font-Names="Calibri" Width="96px" Height="24px" Font-Bold="True"></asp:label><asp:panel id="Panel2" style="Z-INDEX: 170; LEFT: 8px; POSITION: absolute; TOP: 600px" runat="server"
				Width="896px" Height="88px" BackColor="Desktop"></asp:panel><asp:textbox id="val1" style="Z-INDEX: 171; LEFT: 560px; POSITION: absolute; TOP: 104px" runat="server"
				Width="40px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="val2" style="Z-INDEX: 172; LEFT: 608px; POSITION: absolute; TOP: 104px" runat="server"
				Width="40px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="Val3" style="Z-INDEX: 173; LEFT: 656px; POSITION: absolute; TOP: 104px" runat="server"
				Width="40px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="val4" style="Z-INDEX: 174; LEFT: 704px; POSITION: absolute; TOP: 104px" runat="server"
				Width="40px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="TxtFlg1" style="Z-INDEX: 175; LEFT: 656px; POSITION: absolute; TOP: 568px" runat="server"
				Width="64px" Visible="False"></asp:textbox><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" style="Z-INDEX: 176; LEFT: 416px; POSITION: absolute; TOP: 616px"
				runat="server" Width="350px" Height="50px" Visible="False"></CR:CRYSTALREPORTVIEWER><asp:label id="l1" style="Z-INDEX: 177; LEFT: 792px; POSITION: absolute; TOP: 608px" runat="server"
				Width="105px" Height="24px"></asp:label><asp:panel id="Panel6" style="Z-INDEX: 178; LEFT: 916px; POSITION: absolute; TOP: 0px" runat="server"
				Width="20px" Height="1114px" BackColor="Desktop"></asp:panel><asp:textbox id="TxtDtVal" style="Z-INDEX: 179; LEFT: 752px; POSITION: absolute; TOP: 304px"
				tabIndex="11" runat="server" Font-Names="Calibri" Width="96px" Height="24px" Font-Size="Small" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:image id="Image1" style="Z-INDEX: 180; LEFT: 8px; POSITION: absolute; TOP: 144px" runat="server"
				Width="898px" Height="8px" BackColor="Desktop"></asp:image><asp:textbox id="TxtPrLno" style="Z-INDEX: 181; LEFT: 216px; POSITION: absolute; TOP: 72px" runat="server"
				Width="80px"></asp:textbox><asp:label id="Label38" style="Z-INDEX: 182; LEFT: 56px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Names="Calibri" Width="136px" Height="8px"> LOAN REF</asp:label><asp:textbox id="TxtRef" style="Z-INDEX: 183; LEFT: 816px; POSITION: absolute; TOP: 48px" runat="server"
				Width="32px" Visible="False"></asp:textbox><asp:button id="Button1" style="Z-INDEX: 184; LEFT: 136px; POSITION: absolute; TOP: 496px" runat="server"
				Font-Names="Calibri" Width="288px" Height="24px" Text="PENDING   CREDIT INVOICES" BorderColor="Olive" BackColor="#C0FFFF"></asp:button><asp:button id="BtnDbtInv" style="Z-INDEX: 110; LEFT: 576px; POSITION: absolute; TOP: 520px"
				runat="server" Font-Names="Calibri" Width="306px" Text=" DEBIT INVOICES" BorderColor="Olive" BackColor="#FF80FF"></asp:button><asp:button id="BtnCreInv" style="Z-INDEX: 185; LEFT: 136px; POSITION: absolute; TOP: 520px"
				runat="server" Font-Names="Calibri" Width="288px" Height="24px" Text="CREDIT INVOICE" BorderColor="Olive" BackColor="#FF80FF"></asp:button>
			<asp:TextBox id="TextBox1" style="Z-INDEX: 186; LEFT: 216px; POSITION: absolute; TOP: 176px"
				runat="server" Height="26px" Width="96px"></asp:TextBox>
			<asp:label id="Label1" style="Z-INDEX: 187; LEFT: 56px; POSITION: absolute; TOP: 176px" runat="server"
				Height="24px" Width="160px" Font-Names="Calibri">SETTLEMENT AMOUNT</asp:label>
			<asp:label id="Label40" style="Z-INDEX: 188; LEFT: 392px; POSITION: absolute; TOP: 72px" runat="server"
				Height="8px" Width="136px" Font-Names="Calibri">NEW LOAN NO</asp:label></form>
	</body>
</HTML>
