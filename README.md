# TodoMVC
### Overview
The version of the website is Compile-to-JS -> Elm
https://todomvc.com/examples/elm/  
Automated tests for TodoMVC demo app using:
- C#
- Selenium
- NUnit
- Page Object Model

### Test Scenarios:
- Add new item
- Remove item
- Edit item
- Mark item as completed

### Setup
```
git clone https://github.com/salichalak/TodoMvcSystemTests.git
```
```  
cd TodoMvcSystemTests
```
``` 
dotnet restore  
```  
```  
dotnet test  
```  
### Project Structure
TodoMvcSystemTests/  
│  
├── Driver/         
├── Pages/          
├── Tests/          
├── Config/  
├── TestData/        
├── appsettings.json  
├── .gitignore  
├── TodoMvcSystemTests.csproj  
└── README.md  

### Configuration
  "TestSettings": {  
    "BaseUrl": "https://todomvc.com/examples/elm/"  
    }   
