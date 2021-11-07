# Pierre's Bakery

### ***An [Asp.Net](http://asp.Net) MVC Web App that handles flavors and their treats within a migrated MySQL Database using Authentication and Authorization.***

### **By *Aaron Kauffman***

## **Description**

*This web application helps a hypothetical bakery owner manage their flavors and treats.* 

# Instructions

1. Clone the repository.
2. Add the file `appsettings.json` to the `PierresBakery` folder. ***It's contents also include other MVC files and folders.***
3. Here's what `appsettings.json` should contain for this specific project. Replace your [DATABASE] and [PASSWORD] appropriately.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=kauffman_aaron;uid=root;pwd=password;"
  }
}
```

1. From the uppermost directory of your project run:

```bash
cd PierresBakery && dotnet run
```

## **Technologies Used**

- C#, MVC, [Asp.Net](http://asp.Net) Core, EF Core, MySQL, Identity.
- HTML, JS, CSS, Bootstrap, git

## **Known Bugs**

- None found so far. Go ahead and break it i guess.

## **License**

[MIT](https://choosealicense.com/licenses/mit/)

## **Contact Information**

*If you run into any issues, remember: Stop, Drop, and Roll. Or, Contact Aaron at: [Aaron.Christian.Kauffman@gmail.com](mailto:Aaron.Christian.Kauffman@gmail.com)*