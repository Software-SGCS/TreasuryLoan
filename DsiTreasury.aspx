<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DsiTreasury.aspx.vb" Inherits="TreasuryLoan.DsiTreasury" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Menu</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
		<LINK href="imgs/common.css" type="text/css" rel="stylesheet">
		<SCRIPT language="JavaScript" src="imgs/main.js" type="text/javascript"></SCRIPT>
		<SCRIPT src="imgs/ad_head0.js" type="text/javascript"></SCRIPT>
		<SCRIPT src="imgs/cnn_adspaces.js" type="text/javascript"></SCRIPT>
		<script language="javascript">
		
		function loadConsumer(a,b)
			{
			document.getElementById("IFF").src=a
			document.getElementById("IFF").height=b
			
			}
		</script>
		<script language="JavaScript">

function autoResize(id){
    var newheight;
    var newwidth;

    if(document.getElementById){
        newheight=document.getElementById(id).contentWindow.document.body.scrollHeight;
       // newwidth=document.getElementById(id).contentWindow.document.body.scrollWidth;
		}

		//document.getElementById(id).height= (newheight) + "px";
		document.getElementById(id).height= (newheight) + "px";
    //document.getElementById(id).width= (newwidth) + "px";
		}

		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<table cellSpacing="0" cellPadding="0" width="100%" border="0">
			<tr>
				<td colSpan="2">
					<table cellSpacing="0" cellPadding="0" width="100%" border="0">
						<tr>
							<td>
								<TABLE id="cnnCeil" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TBODY>
										<TR>
											<TD vAlign="bottom" width="218" rowSpan="2"><A href="http://edition.cnn.com/"><IMG height="45" hspace="0" src="imgs11/logo.cnn.com.gif" width="218" border="0"></A></TD>
											<TD align="right" width="658" colSpan="2" height="18">&nbsp;</TD>
										</TR>
										<TR height="27">
											<TD class="cnnCeilW">
												<SCRIPT language="javascript" type="text/javascript">
		if (typeof(CNN_returnUserName) != "undefined") {
			CNN_returnUserName('firstName');
		} else {
			document.write('Member Center: <a href="http://audience.cnn.com/services/intl/memberservices/regwall/member_profile.jsp?source=intl">Sign In<\/a> | <a href="http://audience.cnn.com/services/cnn/memberservices/member_register.jsp?pid=&source=cnn&url=http%3A%2F%2Faudience.cnn.com%2Fservices%2Fintl%2Fmemberservices%2Fregwall%2Fmember_profile.jsp%3Fsource%3Dintl">Register<\/a>');
		}
												</SCRIPT>
												<NOSCRIPT>
													Member Center: <A href="http://audience.cnn.com/services/intl/memberservices/regwall/member_profile.jsp?source=intl">
														Sign In</A> | <A href="http://audience.cnn.com/services/cnn/memberservices/member_register.jsp?pid=&amp;source=cnn&amp;url=http%3A%2F%2Faudience.cnn.com%2Fservices%2Fintl%2Fmemberservices%2Fregwall%2Fmember_profile.jsp%3Fsource%3Dintl">
														Register</A>
												</NOSCRIPT>
											</TD>
											<TD class="cnnCeilW" align="right"></TD>
										</TR>
									</TBODY>
								</TABLE>
							</td>
						</tr>
						<tr>
							<td background="imgs11/vert.divider.gif" height="29">&nbsp;</td>
						</tr>
					</table>
				</td>
			</tr>
			<tr>
				<td vAlign="top" width="16%">
					<table cellSpacing="0" cellPadding="0" width="154" border="0">
						<tr>
							<td width="1">
							<TD id="cnnNavBar" width="153"><!-- navbar-->
								<UL id="IntlNav">
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Entry1.aspx?uid=<%=request.Querystring("uid") %>','800')"> INVOICE</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('EntryA.aspx?uid=<%=request.Querystring("uid") %>','800')">AMENDED INVOICE</A></DIV>
									</LI>
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('EntrySettlemn.aspx?uid=<%=request.Querystring("uid") %>','800')">SETTLEMENT INVOICE</A></DIV>
									</LI>
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('LenderReport.aspx','800')">PENDING CREDIT INVOICES</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('BorrowReport.aspx','800')">PENDING DEBIT INVOICES</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('LoanRegister.aspx','800')">LOAN REGISTER</A></DIV>
									</LI>
									
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('PosInsEntry.aspx','800')">LOAN SETTLEMENT</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('PosEntryCus.aspx','800')">New Lender</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('PosEntryCus1.aspx','800')">New Borrower</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
								</UL>
							</TD>
						</tr>
					</table>
				</td>
				<td vAlign="top" width="84%"><iframe id="IFF" style="WIDTH: 149.73%" name="IFF" hspace="5" vspace="0" src="Dispaly1.aspx"
						frameBorder="0" width="100%" scrolling="no" height="600"></iframe>
				</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
		</table>
	</body>
</HTML>
