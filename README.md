# Web-Sunglass-shop (unfinish)
<p>
  In this project ,I use in: HTML, CSS, JS, SQL . The programming environments is ASP.NET MVC.

  The project contains many parts first I will explain the structure of the project.
</p>
  <h3>The structure of the project</h3> 
<pre>
  <h5>The DataLibary :</h5>
    directory contains classes and a generic class for saving data to SQL Server.
</pre>

<pre>
 <h5>WebSunglass :</h5>
    App_Data- contains files like databases and XML.
  </br>
    App_start- Contains classes that will run when the applection starts, usually Config files.
  </br>
    Content- contain CSS and image.
  </br>
    MVC is Model View Controller.
  </br>
    Controllers- A class that deals with user requests, usually used by the viewer.
      The Controller is responsible for responding to the requests and directing to the appropriate view.
      It is also the mediator between the model and the view.
   </br>
    Views- The Views folder contains a sharing folder that contains HTML files that are shared for some HTML files(Layout).
      The View is basically what is shown to user ie user interface.
   </br>
    Models- The model represents the data and retains the application data.
      Usually the files saved to SQL are the models.
</pre>
<h3>Description of files and classes in the project.</h3>
<pre>
  <h5>Views/Home:</h5>
    Index- is home page.
    Contact- to contact with the website owner.
    About- about the website owner.
    SignUp- to sign up to Website that allow you to login and to enter the shop, and buy or sell sunglass.
    Login- to enter the shop.
  </br>
  <h5>Views/Shop:</h5>
    Homepage-allow to manage your item in the shop like add item and watch them and other things.
    Exit- to exit shop and back to Views/Home.
    Shop- contain all item to buy of all user Website.  
</pre>
</br>
<pre>
  <h5>Content:</h5>
    HomeShop.css-is for Home shop(view).
    LoginCustomer.css if for Login(view).
  </br>
  <h5>Layout:</h5>
      CustomerShop.css: is for all Views/Shop.
      Layout.css: is for all Views/Home.
</pre>
</br>
<pre>
    <h5>Class:</h5>
      WebSunglass/Models/Customer: the Customer class is for signup view,contain  the information of customer 
      that sign up to website.
      WebSunglass/Models/Product: the item that customer upload to the shop.
    </br>
      DataLibary/Models/CustomerModel: contain the data of the customer that will save in the SQL Server.
      DataLibary/Logic/CustomerProcessor: contain the logic of save customer to SQL Server.
      DataLibary/DataAccess/SqlDataAccess: to connect SQL Server and save/execute query.
</pre>
</br>
<pre>
  <h5>Controller:</h5>
    Home: His job is to be in charge of the Views, which is under the HOME folder.
    Shop:  His job to be in charge of the Views, which is under the Shop folder.
</pre>
