<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<script type="text/javascript" src="js/SignUp.js"></script>
<link type="text/css" rel="stylesheet" href="css/SignUpNew.css" />
<link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

<link rel="stylesheet"
	href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
<script src="https://code.jquery.com/jquery-1.12.4.js"></script>
<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
<script>
	$(document).ready(function() {
		var today = new Date();
		$('.datepicker').datepicker({
			format : 'mm-dd-yyyy',
			autoclose : true,
			endDate : "today",
			maxDate : today
		}).on('changeDate', function(ev) {
			$(this).datepicker('hide');
		});

		$('.datepicker').keyup(function() {
			if (this.value.match(/[^0-9]/g)) {
				this.value = this.value.replace(/[^0-9^-]/g, '');
			}
		});
	});
</script>

<title>Horizon Account</title>
<link rel="SHORTCUT ICON" href="images/top.png" />
</head>
<body>
	<form>
		<script>
			function goBack() {
				window.history.back()
			}
		</script>
	</form>
	<form name="frmAirways" action="RegistrationServlet" method="post"
		onsubmit="return doValidate()">

		<table width="100%">
			<i class="fa fa-chevron-circle-left" type="button" value="Go back!"
				style="font-size: 26px; color: firebrick;" onclick="history.back()"></i>

			<tr height="40px" id="img1">
				<th><center>
						<img src="images/logo_new.PNG" height="92" width="642">
					</center></th>
			</tr>
			<tr id="img2">
				<th><div class="topnav">

						<a href="Search.jsp">Home</a> <a class="active" href="SignNew.jsp">Register</a>
						<a href="Login.jsp">Login</a>
						<%
							if (session.getAttribute("user") != null) {
						%><a href="Cancel.jsp">Cancel</a>
						<%
							}
						%>
					</div>
					<div class="abc" style="margin-left: 100px; margin-right: 650px;">
						<center>
							<br>
							<%
								String msg = (String) request.getAttribute("msg");
								if (msg != null) {
									out.print(msg);
								}
							%>
							<table>

								<tr align="center">
									<th colspan="2" style="text-align: center"><font
										size="4px">
											<h1>Register</h1>
									</font></th>
								</tr>
								<tr id="p1">
									<th><font color="black" size="4px"> First Name:<font
											style="color: red;">*</font>
									</font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="text"
										name="firstName" placeholder=" Enter first name" /><br /> <br />
										<span id="errFirstname"></span>
									</td> &nbsp;&nbsp;
								<tr id="p1">
									<th><font color="black" size="4px"> Last Name:<font
											style="color: red;">*</font>
									</font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="text"
										name="lastName" placeholder=" Enter last name" /><br /> <br />
										<span id="errLastname"></span>
									</td>
								</tr>
								<tr id="p1">
									<th><font color="black" size="4px"> E-mail: <font
											style="color: red;">*</font></font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="email"
										name="email" placeholder=" Enter  E-mail Id" /> <br /> <br />
										<span id="errEmail"></span>
									</td>
								<tr id="p2">
									<th><font color="black" size="4px"> Password:<font
											style="color: red;">*</font>
									</font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="password"
										name="password" placeholder="E.g Abcd@123#" /> <br /> <br />
										<span id="errPassword" style="color: red;"></td>
								</tr>
								<tr id="p2">
									<th><font color="black" size="4px">Retype Password:<font
											style="color: red;">*</font>
									</font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="password"
										name="retypePassword" placeholder=" Enter Password Again" />
										<br /> <br /> <span id="errRePasswordError"></span>
									</td>
								</tr>
								<tr id="p2">
									<th><font color="black" size="4px"> Date Of Birth:<font
											style="color: red;">*</font>
									</font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp; <input type="text"
										class="datepicker" name="dateOfBirth" placeholder="MM/dd/yyyy" />
										<!-- <input type="date"
										 name="dateOfBirth" placeholder="MM-dd-yyyy"
										required> <br /> <br />  -->
										<span id="errDate"></span>
									</td>
								</tr>
								<tr id="p2">
									<th><font color="black" size="4px">Gender: </font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp; <input type="radio"
										name="gender" value="male"> Male <input type="radio"
										name="gender" value="female"> Female <input
										type="radio" name="gender" value="other"> Other <br />
										<br />
								</tr>
								&nbsp;&nbsp;
								<tr id="p2">
									<th><font color="black" size="4px"> Contact Number:<font
											style="color: red;">*</font>
									</font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="number"
										name="contactNo" placeholder="Enter contact Numer" /> <br />
										<br /> <span id="errContactNo"></span></td>
								</tr>
								<tr id="p3">
									<th><font color="black" size="4px"> SSN type: </font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp; <select name="ssnType"
										style="height: 35px">
											<option value="0" disabled selected>Select Type</option>
											<option value="1">Aadhar Card</option>
											<option value="2">Pan Card</option>

									</select> <br /> <br /></td>
								</tr>
								<tr id="p2">
									<th><font color="black" size="4px">SSN Number: </font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<input type="text"
										name="ssnNo" placeholder="SSN Number" /> <br /> <br /></td>
								</tr>
								<tr>
									<th><font color="black" size="4px">Address: </font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<textarea rows="4" cols="40"
											name="address" placeholder="Enter Your Address here" /></textarea> <br />
										<br /></td>
								</tr>
								<tr>
									<th><font color="black" size="4px">City: </font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp; <select name="city"
										style="height: 35px">

											<option value="" disabled selected>Select City</option>
											<option>Ahmedabad</option>
											<option>Bengaluru/Bangalore</option>
											<option>Chandigarh</option>
											<option>Chennai</option>
											<option>Delhi</option>
											<option>Gurgaon</option>
											<option>Hyderabad/Secunderabad</option>
											<option>Kolkatta</option>
											<option>Mumbai</option>
											<option>Noida</option>
											<option>Pune</option>
											<option>Anantapur</option>
											<option>Guntakal</option>
											<option>Guntur</option>
											<option>Hyderabad/Secunderabad</option>
											<option>kakinada</option>
											<option>kurnool</option>
											<option>Nellore</option>
											<option>Nizamabad</option>
											<option>Rajahmundry</option>
											<option>Tirupati</option>
											<option>Vijayawada</option>
											<option>Visakhapatnam</option>
											<option>Warangal</option>
											<option>Andra Pradesh-Other</option>
											<option>Itanagar</option>
											<option>Arunachal Pradesh-Other</option>
											<option>Guwahati</option>
											<option>Silchar</option>
											<option>Assam-Other</option>
											<option>Bhagalpur</option>
											<option>Patna</option>
											<option>Bihar-Other</option>
											<option>Bhillai</option>
											<option>Bilaspur</option>
											<option>Raipur</option>
											<option>Chhattisgarh-Other</option>
											<option>Panjim/Panaji</option>
											<option>Vasco Da Gama</option>
											<option>Goa-Other</option>
											<option>Ahmedabad</option>
											<option>Anand</option>
											<option>Ankleshwar</option>
											<option>Bharuch</option>
											<option>Bhavnagar</option>
											<option>Bhuj</option>
											<option>Gandhinagar</option>
											<option>Gir</option>
											<option>Jamnagar</option>
											<option>Kandla</option>
											<option>Porbandar</option>
											<option>Rajkot</option>
											<option>Surat</option>
											<option>Vadodara/Baroda</option>
											<option>Valsad</option>
											<option>Vapi</option>
											<option>Gujarat-Other</option>
											<option>Ambala</option>
											<option>Chandigarh</option>
											<option>Faridabad</option>
											<option>Gurgaon</option>
											<option>Hisar</option>
											<option>Karnal</option>
											<option>Kurukshetra</option>
											<option>Panipat</option>
											<option>Rohtak</option>
											<option>Haryana-Other</option>
											<option>Dalhousie</option>
											<option>Dharmasala</option>
											<option>Kulu/Manali</option>
											<option>Shimla</option>
											<option>Himachal Pradesh-Other</option>
											<option>Jammu</option>
											<option>Srinagar</option>
											<option>Jammu and Kashmir-Other</option>
											<option>Bokaro</option>
											<option>Dhanbad</option>
											<option>Jamshedpur</option>
											<option>Ranchi</option>
											<option>Jharkhand-Other</option>
											<option>Bengaluru/Bangalore</option>
											<option>Belgaum</option>
											<option>Bellary</option>
											<option>Bidar</option>
											<option>Dharwad</option>
											<option>Gulbarga</option>
											<option>Hubli</option>
											<option>Kolar</option>
											<option>Mangalore</option>
											<option>Mysoru/Mysore</option>
											<option>Karnataka-Other</option>
											<option>Calicut</option>
											<option>Cochin</option>
											<option>Ernakulam</option>
											<option>Kannur</option>
											<option>Kochi</option>
											<option>Kollam</option>
											<option>Kottayam</option>
											<option>Kozhikode</option>
											<option>Palakkad</option>
											<option>Palghat</option>
											<option>Thrissur</option>
											<option>Trivandrum</option>
											<option>Kerela-Other</option>
											<option>Bhopal</option>
											<option>Gwalior</option>
											<option>Indore</option>
											<option>Jabalpur</option>
											<option>Ujjain</option>
											<option>Madhya Pradesh-Other</option>
											<option>Ahmednagar</option>
											<option>Aurangabad</option>
											<option>Jalgaon</option>
											<option>Kolhapur</option>
											<option>Mumbai</option>
											<option>Mumbai Suburbs</option>
											<option>Nagpur</option>
											<option>Nasik</option>
											<option>Navi Mumbai</option>
											<option>Pune</option>
											<option>Solapur</option>
											<option>Maharashtra-Other</option>
											<option>Imphal</option>
											<option>Manipur-Other</option>
											<option>Shillong</option>
											<option>Meghalaya-Other</option>
											<option>Aizawal</option>
											<option>Mizoram-Other</option>
											<option>Dimapur</option>
											<option>Nagaland-Other</option>
											<option>Bhubaneshwar</option>
											<option>Cuttak</option>
											<option>Paradeep</option>
											<option>Puri</option>
											<option>Rourkela</option>
											<option>Orissa-Other</option>
											<option>Amritsar</option>
											<option>Bathinda</option>
											<option>Chandigarh</option>
											<option>Jalandhar</option>
											<option>Ludhiana</option>
											<option>Mohali</option>
											<option>Pathankot</option>
											<option>Patiala</option>
											<option>Punjab-Other</option>
											<option>Ajmer</option>
											<option>Jaipur</option>
											<option>Jaisalmer</option>
											<option>Jodhpur</option>
											<option>Kota</option>
											<option>Udaipur</option>
											<option>Rajasthan-Other</option>
											<option>Gangtok</option>
											<option>Sikkim-Other</option>
											<option>Chennai</option>
											<option>Coimbatore</option>
											<option>Cuddalore</option>
											<option>Erode</option>
											<option>Hosur</option>
											<option>Madurai</option>
											<option>Nagerkoil</option>
											<option>Ooty</option>
											<option>Salem</option>
											<option>Thanjavur</option>
											<option>Tirunalveli</option>
											<option>Trichy</option>
											<option>Tuticorin</option>
											<option>Vellore</option>
											<option>Tamil Nadu-Other</option>
											<option>Agartala</option>
											<option>Tripura-Other</option>
											<option>Chandigarh</option>
											<option>Dadra & Nagar Haveli-Silvassa</option>
											<option>Daman & Diu</option>
											<option>Delhi</option>
											<option>Pondichery</option>
											<option>Agra</option>
											<option>Aligarh</option>
											<option>Allahabad</option>
											<option>Bareilly</option>
											<option>Faizabad</option>
											<option>Ghaziabad</option>
											<option>Gorakhpur</option>
											<option>Kanpur</option>
											<option>Lucknow</option>
											<option>Mathura</option>
											<option>Meerut</option>
											<option>Moradabad</option>
											<option>Noida</option>
											<option>Varanasi/Banaras</option>
											<option>Uttar Pradesh-Other</option>
											<option>Dehradun</option>
											<option>Roorkee</option>
											<option>Uttaranchal-Other</option>
											<option>Asansol</option>
											<option>Durgapur</option>
											<option>Haldia</option>
											<option>Kharagpur</option>
											<option>Kolkatta</option>
											<option>Siliguri</option>
											<option>West Bengal - Other</option>

									</select> <br /> <br /></td>
								</tr>
								<tr>
									<th><font color="black" size="4px">State: </font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<select name="state"
										style="height: 35px">

											<option value="" disabled selected>Select State</option>
											<option value="Andaman and Nicobar Islands">Andaman
												and Nicobar Islands</option>
											<option value="Andhra Pradesh">Andhra Pradesh</option>
											<option value="Arunachal Pradesh">Arunachal Pradesh</option>
											<option value="Assam">Assam</option>
											<option value="Bihar">Bihar</option>
											<option value="Chandigarh">Chandigarh</option>
											<option value="Chhattisgarh">Chhattisgarh</option>
											<option value="Dadra and Nagar Haveli">Dadra and
												Nagar Haveli</option>
											<option value="Daman and Diu">Daman and Diu</option>
											<option value="Delhi">Delhi</option>
											<option value="Goa">Goa</option>
											<option value="Gujarat">Gujarat</option>
											<option value="Haryana">Haryana</option>
											<option value="Himachal Pradesh">Himachal Pradesh</option>
											<option value="Jammu and Kashmir">Jammu and Kashmir</option>
											<option value="Jharkhand">Jharkhand</option>
											<option value="Karnataka">Karnataka</option>
											<option value="Kerala">Kerala</option>
											<option value="Lakshadweep">Lakshadweep</option>
											<option value="Madhya Pradesh">Madhya Pradesh</option>
											<option value="Maharashtra">Maharashtra</option>
											<option value="Manipur">Manipur</option>
											<option value="Meghalaya">Meghalaya</option>
											<option value="Mizoram">Mizoram</option>
											<option value="Nagaland">Nagaland</option>
											<option value="Orissa">Orissa</option>
											<option value="Pondicherry">Pondicherry</option>
											<option value="Punjab">Punjab</option>
											<option value="Rajasthan">Rajasthan</option>
											<option value="Sikkim">Sikkim</option>
											<option value="Tamil Nadu">Tamil Nadu</option>
											<option value="Tripura">Tripura</option>
											<option value="Uttaranchal">Uttaranchal</option>
											<option value="Uttar Pradesh">Uttar Pradesh</option>
											<option value="West Bengal">West Bengal</option>
									</select> <br /> <br /></td>
								</tr>
								<tr>
									<th><font color="black" size="4px" disabled selected>Country:
									</font></th>
									<td>&nbsp;&nbsp;&nbsp;&nbsp;<select name="country"
										style="height: 35px">

											<option value="">Select Country</option>
											<option value="AF">Afghanistan</option>
											<option value="AX">�land Islands</option>
											<option value="AL">Albania</option>
											<option value="DZ">Algeria</option>
											<option value="AS">American Samoa</option>
											<option value="AD">Andorra</option>
											<option value="AO">Angola</option>
											<option value="AI">Anguilla</option>
											<option value="AQ">Antarctica</option>
											<option value="AG">Antigua and Barbuda</option>
											<option value="AR">Argentina</option>
											<option value="AM">Armenia</option>
											<option value="AW">Aruba</option>
											<option value="AU">Australia</option>
											<option value="AT">Austria</option>
											<option value="AZ">Azerbaijan</option>
											<option value="BS">Bahamas</option>
											<option value="BH">Bahrain</option>
											<option value="BD">Bangladesh</option>
											<option value="BB">Barbados</option>
											<option value="BY">Belarus</option>
											<option value="BE">Belgium</option>
											<option value="BZ">Belize</option>
											<option value="BJ">Benin</option>
											<option value="BM">Bermuda</option>
											<option value="BT">Bhutan</option>
											<option value="BO">Bolivia</option>
											<option value="BQ">Bonaire</option>
											<option value="BA">Bosnia and Herzegovina</option>
											<option value="BW">Botswana</option>
											<option value="BV">Bouvet Island</option>
											<option value="BR">Brazil</option>

											<option value="BN">Brunei Darussalam</option>
											<option value="BG">Bulgaria</option>
											<option value="BF">Burkina Faso</option>
											<option value="BI">Burundi</option>
											<option value="KH">Cambodia</option>
											<option value="CM">Cameroon</option>
											<option value="CA">Canada</option>
											<option value="CV">Cape Verde</option>
											<option value="KY">Cayman Islands</option>
											<option value="CF">Central African Republic</option>
											<option value="TD">Chad</option>
											<option value="CL">Chile</option>
											<option value="CN">China</option>
											<option value="CX">Christmas Island</option>
											<option value="CC">Cocos (Keeling) Islands</option>
											<option value="CO">Colombia</option>
											<option value="KM">Comoros</option>
											<option value="CG">Congo</option>


											<option value="CK">Cook Islands</option>
											<option value="CR">Costa Rica</option>
											<option value="CI">C�te d'Ivoire</option>
											<option value="HR">Croatia</option>
											<option value="CU">Cuba</option>
											<option value="CW">Cura�ao</option>
											<option value="CY">Cyprus</option>
											<option value="CZ">Czech Republic</option>
											<option value="DK">Denmark</option>
											<option value="DJ">Djibouti</option>
											<option value="DM">Dominica</option>
											<option value="DO">Dominican Republic</option>
											<option value="EC">Ecuador</option>
											<option value="EG">Egypt</option>
											<option value="SV">El Salvador</option>
											<option value="GQ">Equatorial Guinea</option>
											<option value="ER">Eritrea</option>
											<option value="EE">Estonia</option>
											<option value="ET">Ethiopia</option>
											<option value="FK">Falkland Islands (Malvinas)</option>
											<option value="FO">Faroe Islands</option>
											<option value="FJ">Fiji</option>
											<option value="FI">Finland</option>
											<option value="FR">France</option>
											<option value="GF">French Guiana</option>
											<option value="PF">French Polynesia</option>
											<option value="TF">French Southern Territories</option>
											<option value="GA">Gabon</option>
											<option value="GM">Gambia</option>
											<option value="GE">Georgia</option>
											<option value="DE">Germany</option>
											<option value="GH">Ghana</option>
											<option value="GI">Gibraltar</option>
											<option value="GR">Greece</option>
											<option value="GL">Greenland</option>
											<option value="GD">Grenada</option>
											<option value="GP">Guadeloupe</option>
											<option value="GU">Guam</option>
											<option value="GT">Guatemala</option>
											<option value="GG">Guernsey</option>
											<option value="GN">Guinea</option>
											<option value="GW">Guinea-Bissau</option>
											<option value="GY">Guyana</option>
											<option value="HT">Haiti</option>

											<option value="VA">Holy See (Vatican City State)</option>
											<option value="HN">Honduras</option>
											<option value="HK">Hong Kong</option>
											<option value="HU">Hungary</option>
											<option value="IS">Iceland</option>
											<option value="IN">India</option>
											<option value="ID">Indonesia</option>
											<option value="IR">Iran</option>
											<option value="IQ">Iraq</option>
											<option value="IE">Ireland</option>
											<option value="IM">Isle of Man</option>
											<option value="IL">Israel</option>
											<option value="IT">Italy</option>
											<option value="JM">Jamaica</option>
											<option value="JP">Japan</option>
											<option value="JE">Jersey</option>
											<option value="JO">Jordan</option>
											<option value="KZ">Kazakhstan</option>
											<option value="KE">Kenya</option>
											<option value="KI">Kiribati</option>

											<option value="KR">Korea</option>
											<option value="KW">Kuwait</option>
											<option value="KG">Kyrgyzstan</option>
											<option value="LA">Lao</option>
											<option value="LV">Latvia</option>
											<option value="LB">Lebanon</option>
											<option value="LS">Lesotho</option>
											<option value="LR">Liberia</option>
											<option value="LY">Libya</option>
											<option value="LI">Liechtenstein</option>
											<option value="LT">Lithuania</option>
											<option value="LU">Luxembourg</option>
											<option value="MO">Macao</option>
											<option value="MK">Macedonia</option>
											<option value="MG">Madagascar</option>
											<option value="MW">Malawi</option>
											<option value="MY">Malaysia</option>
											<option value="MV">Maldives</option>
											<option value="ML">Mali</option>
											<option value="MT">Malta</option>
											<option value="MH">Marshall Islands</option>
											<option value="MQ">Martinique</option>
											<option value="MR">Mauritania</option>
											<option value="MU">Mauritius</option>
											<option value="YT">Mayotte</option>
											<option value="MX">Mexico</option>
											<option value="FM">Micronesia</option>
											<option value="MD">Moldova, Republic of</option>
											<option value="MC">Monaco</option>
											<option value="MN">Mongolia</option>
											<option value="ME">Montenegro</option>
											<option value="MS">Montserrat</option>
											<option value="MA">Morocco</option>
											<option value="MZ">Mozambique</option>
											<option value="MM">Myanmar</option>
											<option value="NA">Namibia</option>
											<option value="NR">Nauru</option>
											<option value="NP">Nepal</option>
											<option value="NL">Netherlands</option>
											<option value="NC">New Caledonia</option>
											<option value="NZ">New Zealand</option>
											<option value="NI">Nicaragua</option>
											<option value="NE">Niger</option>
											<option value="NG">Nigeria</option>
											<option value="NU">Niue</option>
											<option value="NF">Norfolk Island</option>
											<option value="MP">Northern Mariana Islands</option>
											<option value="NO">Norway</option>
											<option value="OM">Oman</option>
											<option value="PK">Pakistan</option>
											<option value="PW">Palau</option>
											<option value="PS">Palestinian Territory</option>
											<option value="PA">Panama</option>
											<option value="PG">Papua New Guinea</option>
											<option value="PY">Paraguay</option>
											<option value="PE">Peru</option>
											<option value="PH">Philippines</option>
											<option value="PN">Pitcairn</option>
											<option value="PL">Poland</option>
											<option value="PT">Portugal</option>
											<option value="PR">Puerto Rico</option>
											<option value="QA">Qatar</option>
											<option value="RE">R�union</option>
											<option value="RO">Romania</option>
											<option value="RU">Russian Federation</option>
											<option value="RW">Rwanda</option>
											<option value="BL">Saint Barth�lemy</option>
											<option value="SH">Saint Helena</option>
											<option value="KN">Saint Kitts and Nevis</option>
											<option value="LC">Saint Lucia</option>
											<option value="MF">Saint Martin (French part)</option>
											<option value="PM">Saint Pierre and Miquelon</option>
											<option value="VC">Saint Vincent and the Grenadines</option>
											<option value="WS">Samoa</option>
											<option value="SM">San Marino</option>
											<option value="ST">Sao Tome and Principe</option>
											<option value="SA">Saudi Arabia</option>
											<option value="SN">Senegal</option>
											<option value="RS">Serbia</option>
											<option value="SC">Seychelles</option>
											<option value="SL">Sierra Leone</option>
											<option value="SG">Singapore</option>
											<option value="SX">Sint Maarten (Dutch part)</option>
											<option value="SK">Slovakia</option>
											<option value="SI">Slovenia</option>
											<option value="SB">Solomon Islands</option>
											<option value="SO">Somalia</option>
											<option value="ZA">South Africa</option>
											<option value="GS">South Georgia</option>
											<option value="SS">South Sudan</option>
											<option value="ES">Spain</option>
											<option value="LK">Sri Lanka</option>
											<option value="SD">Sudan</option>
											<option value="SR">Suriname</option>
											<option value="SJ">Svalbard and Jan Mayen</option>
											<option value="SZ">Swaziland</option>
											<option value="SE">Sweden</option>
											<option value="CH">Switzerland</option>
											<option value="SY">Syrian Arab Republic</option>
											<option value="TW">Taiwan, Province of China</option>
											<option value="TJ">Tajikistan</option>
											<option value="TZ">Tanzania</option>
											<option value="TH">Thailand</option>
											<option value="TL">Timor-Leste</option>
											<option value="TG">Togo</option>
											<option value="TK">Tokelau</option>
											<option value="TO">Tonga</option>
											<option value="TT">Trinidad and Tobago</option>
											<option value="TN">Tunisia</option>
											<option value="TR">Turkey</option>
											<option value="TM">Turkmenistan</option>
											<option value="TC">Turks and Caicos Islands</option>
											<option value="TV">Tuvalu</option>
											<option value="UG">Uganda</option>
											<option value="UA">Ukraine</option>
											<option value="AE">United Arab Emirates</option>
											<option value="GB">United Kingdom</option>
											<option value="US">United States</option>

											<option value="UY">Uruguay</option>
											<option value="UZ">Uzbekistan</option>
											<option value="VU">Vanuatu</option>
											<option value="VE">Venezuela</option>
											<option value="VN">Viet Nam</option>
											<option value="VG">Virgin Islands, British</option>
											<option value="VI">Virgin Islands, U.S.</option>
											<option value="WF">Wallis and Futuna</option>
											<option value="EH">Western Sahara</option>
											<option value="YE">Yemen</option>
											<option value="ZM">Zambia</option>
											<option value="ZW">Zimbabwe</option>
									</select> <br /> <br />
									</td>

								</tr>

								<!--  *&nbsp;&nbsp;
						<div class="clearfix">
    <button type="submit" style="font-face: 'Comic Sans MS'; font-size: larger; color:black ; background-color: white;" class="signupbtn">Sign Up</button>
    
      <button type="button" style="font-face: 'Comic Sans MS'; font-size: larger; color:black ; background-color: white;" class="cancelbtn">Cancel</button>
      </div>*/
      </tr>
      &nbsp;&nbsp;-->
								<tr align="center">

									<th colspan="2" style="text-align: center"><input
										type="submit" value="Sign Up"
										style="font-weight: bold; background-color: #4CAF50; color: white; padding: 10px 10px; margin: 4px 0; border: none; cursor: pointer; width: 20%;" />
									</th>
								<tr>
									<td><br></td>
								</tr>
								<tr align="center">

									<td colspan="2">Already have an account ? <a
										href="Login.jsp"
										style="text-decoration: none; color: #2013E5; font-size: 20px; font-style: italic;">Login</a>
									</td>
								</tr>
							</table>
							<br>
						</center>

						<br> <br> <span id="error"></span>
					</div> <br> <br> <br> <br> <br> <br> <br>

					<br> <br> <br> <br> <br> <br> <br>
				</th>
			</tr>
		</table>
	</form>
<%@ include file = "Footer.jsp" %>
</body>
</html>


