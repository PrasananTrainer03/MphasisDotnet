<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<script>
function goBack() {
    window.history.back()
}
</script>
<script type="text/javascript" src="js/LoginValidate.js"></script>
<link type="text/css" rel="stylesheet" href="css/login.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Horizon Account </title>
<link rel="SHORTCUT ICON" href="images/top.png" />
</head>

<body>
<%--  <%
	session.invalidate();
%>  --%>



	<table width="100%">
	<i class="fa fa-chevron-circle-left" type="button" value="Go back!" style="font-size:26px" onclick="history.back()" ></i>
	
		<tr height="40px" id="img1">
			<th><center>
					<img src="images/logo_	new.PNG" height="122" width="642">
				</center></th>
		</tr>
		<tr id="img2">
			<th><div class="topnav">

					<a href="Search.jsp">Home</a> <a href="SignNew.jsp">Register</a>
					<a class="active" href="Login.jsp">Login</a> 
					
				</div> <br> <br> <br> <br>
				<form name="frmLogin" action="LoginServlet" method="post"
					onsubmit="return doValidate()">
				
						<center>
							<br>
							<table style="padding-left: 100px;float:left;">

								<tr align="center">
									<th colspan="2"><font size="5px"> Login </font> <br /> <br /></th>
								</tr>
								<tr id="p1">
									<th><font color="black" size="4px"> E-mail: </font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="email"
										name="email" placeholder="E-mail Id"
										style="width: 80%; padding: 12px 20px; margin: 8px 0; display: inline-block; border: 1px solid #ccc; box-sizing: border-box;" />
										&nbsp;&nbsp;&nbsp;
									</td>
									<td><span id="errEmail" style="color: red;"></span></td>
								</tr>
								<br>
								
								<tr id="p2">
									<th><font color="black" size="4px"> Password: </font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="password"
										name="password" placeholder=" Enter Password"
										style="width: 80%; padding: 12px 20px; margin: 8px 0; display: inline-block; border: 1px solid #ccc; box-sizing: border-box;" />
										&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									</td>
				<td><span id="errPassword" style="color: red;"></span></td>
								</tr>
								<tr><td><br></td></tr>
								&nbsp;&nbsp;
								<tr align="center">
									<th colspan="2"><button id="button" type="submit"
											style="background-color: #4CAF50; color: white; padding: 10px 10px; margin: 4px 0; border: none; cursor: pointer; width: 20%; opacity: 0.8;">
											<b>Login</b>

										</button></th>
										

								</tr>
								<tr>&nbsp;</tr>
								<tr><td><br></td></tr>
								
								<tr>
									<td colspan="2">
										<center>
											<span id="result" style=" color: red; visibility: hidden">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;No such account exsists.<br>Please Register</span>
										</center>
									</td>
								</tr>
							</table>
							<br>


						</center>
						<br> <br><br><br>

					
				</form> <br> <br> <br> <br> <br> <br> <br>
				<br> <br> <br> <br> <br> <br> <br><br> <br> <br> <br> <br> <br> <br>
				<br> <br> <br> <br> <br> <br> <br>
				
			<%@ include file = "Footer.jsp" %>	
</body>
</html>