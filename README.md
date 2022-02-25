# Emp-Auth

register url -(post)
https://localhost:44335/api/Employee
register obj -
{
	"name" : "farhan",
	"email" : "farhan@gmail.com",
	"password": "Farhan@123",
	"phoneNo": 9999999999,
	"DOB" : "2002-02-19"
}

login url - (post)
https://localhost:44335/api/Employee/Login
login obj -
 {
 "email" : "farhan@gmail.com",
	"password": "Farhan@123"
 }
