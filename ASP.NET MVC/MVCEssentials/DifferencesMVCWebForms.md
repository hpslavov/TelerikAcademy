# ASP.NET MVC Essentials Homework #

##01.Differences and Similarities between ASP.NET MVC and ASP.NET Web Forms.##

Both WebForms and MVC are a part of the **ASP.NET** platform. They are both executed under the **IIS**. They both use the inherited ASP.NET **identity**. They are both written in **C#** and they share the common namespaces and features of the **ASP.NET**.

###ASP.NET Web Forms###

----------
	Uses Page controller pattern approach for rendering layout. Every page
	has its own controller(the code behind file) for processing requests.

----------
	No separation of concerns. Each .aspx page is tightly coupled to its
	code behind file.

----------
	Automatic testing is really hard due to tight coupling.

----------
	Viewstate is used in order to achieve stateful behaviour.

----------
	Massively increasing page size due to the Viewstate(transferred between
	client and server).

----------
	Web Forms follows a Page lifecycle and event driven model.

----------
	Minimal knowledge ot HTML,JavaScript and CSS is needed due to the 
	introduced server-side controls.Intention is to create an abstraction 
	over the above-mentioned.

----------
	Due to this abstraction, control over the HTML,JS and CSS is limited.
	Lots of code is generated for you, in a structure wheather or not you
	agree with it.

----------
	With above mentioned approach, is lead to the RAD(rapid application 
	development) model development, no extensive knowledge of technologies
	is needed to develop a small-scale applications at no cost of time.

----------

###ASP.NET MVC###

	MVC uses Fron controller approach. Which means that a common controller
	is used for all page processes and requests.

----------
	Clean separation of concerns. View is separated from the controller.

----------
	Key feature in MVC is the testability. Test driven development approach
	is achieved at easy with the separation of concertns of the MVC pattern.

----------
	MVC approach is stateless, embracing the paradigm of the web. No concept
	of viewstate is mentioned,so the output is clean.

----------
	No Page life cycle is followed, a simple Request life cycle exists in MVC.

----------
	Building an MVC application requires, extensive knowledge of HTML,JS,CSS.
	Which results in a total control of the markup,functions,view.

----------
	MVC design pattern approach,decreases productivity of developers but,
	is recommended for application that are intended to scale.