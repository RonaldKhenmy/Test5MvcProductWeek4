# MvcProduct Week 4 

This app allows users to store a list of products by entering the name of the item, release date, item type, and the price of the item. The application can edit, delete, and see the details of the products in the list. In the details page, you can see how many days an item has been purchased. Includes the usage of routing. It also allows the user to access a list of fish. You can set the date it was caught the age of the fish, register if it is saltwater or freshwater, and the price.

In order to run the app, download the zip folder and extract all the files. You can open up Visual Studio or double-click the folder to access the files. For direct access, double the folder and then double-click the folder MvcProduct. Click on the solution file to open it. If a textbox shows up that asks you to trust it, click okay/yes. Press the green play button that says https or press F5 on your keyboard. If there is a textbox asking you to trust a certificate, click yes. 

Running the program will open a website; the URL will be a localhost:<port#>(The port number is random). Click on the Product app header/link, which will lead you to the Index webpage, where you will find the list of items, release date, item type, and price. The header is located in the top left corner of the page. In order to add products, click on the 'Create new' link and fill in the boxes, and select a date. Finally, press the save button to store the item. When you click on the 'Details' link, you will see a link called 'View Days Since Purchased'. When you click on the link, it will bring you to a page that measures the days since the item was purchased. In order to get out of the page, click the Product app header. If you are done with the app, close the window by clicking on the X-button in the top right corner of the window. Make sure to also close the console command after closing the app. If you click on the 'Fishs app', you will be brought to the Index of the Fishs app. Click on the 'Create new' link and fill in the boxes. The Create page has a drop-down list to choose whether the fish is fresh or saltwater. It also has an age slider so the user can input the age of the fish. Press the save button to store the item. There is also a 'Details' link which tells the user details about the fish. There is also a delete link and button if the user wants to delete the fish from the list. In order to exit the webpage, click on the X icon in the top right corner

Update design-note: 
An interface and service folder were added to the project along with a new view. The app follows the Separation of Concerns by focusing on the single responsibility of measuring time using the interface and service implementation without interfering with the products. The reason AddScoped was used because I wanted services to be created once per client request, which is registered by IDaysPurchased. The reason I chose IDaysPurchased as my dependency injection was to measure the days the item was purchased. Other dependencies include MvcProductsContext for the database and ILogger to send logs to the console command. 

Update Bootstrap-note:
New bootstrap responsive forms have been added to the Create page in the form of a drop-down list and an age slider. Type in /Fishs/Create in the URL to be brought to the Create page. Verified that the keyboard focus, labels, and error messages are correct. A before-and-after screen has been added for comparison. The first and last names of the owner of the webpage have been added to the footer. 
Before <img width="1907" height="1007" alt="Week4Before" src="https://github.com/user-attachments/assets/6d01fa09-d52c-4254-a93a-ed54950cc9f5" /> 

After <img width="1907" height="1007" alt="Week4After" src="https://github.com/user-attachments/assets/6f05e481-114b-4cab-bf4a-4f54ec289487" />

Create <img width="1902" height="1011" alt="Week4Create" src="https://github.com/user-attachments/assets/2528e687-2ad4-4e83-b03e-0aa6a637c1f4" /> 

Index https://localhost:7028/Fishs
Edit https://localhost:7028/Fishs/Edit/2
Tab order <img width="1903" height="883" alt="Week4Taborder" src="https://github.com/user-attachments/assets/a43909a7-f2b1-42bb-be94-7ca0861ead0a" />
