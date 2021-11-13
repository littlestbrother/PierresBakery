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

1. Create a schema in MySQL Workbench- the name of the database ***must*** match the database name from your `appsettings.json`.
2. From within the `PierresBakery` directory; build the database with:

```bash
dotnet ef database update
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

*If you run into any issues, remember: Stop, # Pierre's Bakery
2
​
3
### ***An [Asp.Net](http://asp.Net) MVC Web App that handles flavors and their treats within a migrated MySQL Database using Authentication and Authorization.***
4
​
5
### **By *Aaron Kauffman***
6
​
7
## **Description**
8
​
9
*This web application helps a hypothetical bakery owner manage their flavors and treats.* 
10
​
11
# Instructions
12
​
13
1. Clone the repository.
14
2. Add the file `appsettings.json` to the `PierresBakery` folder. ***It's contents also include other MVC files and folders.***
15
3. Here's what `appsettings.json` should contain for this specific project. Replace your [DATABASE] and [PASSWORD] appropriately.
16
​
17
```json
18
{
19
  "ConnectionStrings": {
20
      "DefaultConnection": "Server=localhost;Port=3306;database=kauffman_aaron;uid=root;pwd=password;"
21
  }
22
}
23
```
24
​
25
1. From the uppermost directory of your project run:
26
​
27
```bash
28
cd PierresBakery && dotnet run
29
```
30
​
31
## **Technologies Used**
32
​
33
- C#, MVC, [Asp.Net](http://asp.Net) Core, EF Core, MySQL, Identity.
34
- HTML, JS, CSS, Bootstrap, git
35
​
36
## **Known Bugs**
37
​
38
- None found so far. Go ahead and break it i guess.
39
​
40
## **License**
41
​
42
[MIT](https://choosealicense.com/licenses/mit/)
43
​
44
## **Contact Information**
45
Drop, and Roll. Or, Contact Aaron at: [Aaron.Christian.Kauffman@gmail.com](mailto:Aaron.Christian.Kauffman@gmail.com)*
