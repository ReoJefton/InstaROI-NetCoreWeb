# InstaROI-Web
InstaROI-Web

Steps to run web app:
1. Download source code zip file, extract it and open the solution in Visual Studio 2022 or clone the repository in Visual Studio 2022.
2. Build solution.
3. In the package manager console run the following commands to run migration Initial(Comment out seed code before doing this - OnModelCreating method in ...\Data\WellBeings_NetCoreAppContext.cs).

         PM> Add-Migration Initial -context WellBeings_NetCoreAppContext
      
         PM> Update-Database -context WellBeings_NetCoreAppContext
   
         PM> Update-Database -context WellBeings_NetCoreAppContext
   
5. Run the solution to see the Website in the browser

   
Enjoy the InstaROI-Web .Net Core Web App!

<img src="https://github.com/reojeffi/InstaROI-Web/blob/master/InstaROI1.png" />
<img src="https://github.com/reojeffi/InstaROI-Web/blob/master/InstaROI2.png" />
<img src="https://github.com/reojeffi/InstaROI-Web/blob/master/InstaROI3.png" />
<img src="https://github.com/reojeffi/InstaROI-Web/blob/master/InstaROI4.png" />

