# Object-Oriented Programming Fundamentals in C#

## The four pillars of object-oriented programming are:
- Abstraction
    - A concept: Simplify reality, ignore extraneous details, focus on what's important for a purpose. 
- Encapsulation
    - A technique: HIding the data and implementation within classes means no other code needs to know/use these details, instead will call a `get()` or `set()` to the class to retrieve information. 
    - This protects the data, allows for authorization before getting data, and allows for validation before setting data. 
    - Helps manage complexity as onlt the class needs to understand the implementation. 
- Inheritance
- Polymorphism

<hr>

## Common Application Layers

- User Interface Layer
- Business Logic Layer
- Data Access Layer (Entity Framework)

<hr>

## Classes in this project:
Customer
- Name
- Email
- Home Address
- Work Address
- `Validate()`
- `Retrieve()`
- `Save()`

Product
- Name
- Description
- Current Price
- `Validate()`
- `Retrieve()`
- `Save()`

Order
- Customer
- Order Date
- Shipping Address
- Order Items
- `Validate()`
- `Retrieve()`
- `Save()`

Order Item
- Product
- Quantity
- Purchase Price
- `Validate()`
- `Retrieve()`
- `Save()`

## The Customer Class

Creating Get/Set

            public class Customer
                {
                    private string _lastName;
                    public string LastName
                    {
                        get
                        {
                            return _lastName;
                        }
                        set
                        {
                            _lastName = value;
                        }
                    }
                }

Or, auto-implement property: 

            public class Customer
                {
                    public string LastName { get; set; }
                }

## Unit Tests

Tests belong in a separate project and folder. Test > Test Explorer > Run All

## Creating a New Object

```
Customer customer1 = new Customer();
```

Assigning a new instance of Customer to object variable `customer1`. The type of the object variable is the type of the created object.
For local use, use `var` instead:

```
var customer1 = new Customer();
```

## Static Modifier

``` public static int InstanceCount { get; set; }```

The static modifier defines members that belong to the class itself and not to an instance of that class. 

```
c1.FirstName = "Bilbo";
Customer.InstanceCount += 1;
 ```