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

## Interface
- empty type... no properties

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

EntityBase 
- a base class for all other classes
- good example for abstract class
- 

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

## Modifiers
<hr>

### Access Modifiers

- public: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
- private: The type or member can be accessed only by code in the same class or struct.
- protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
- internal: The type or member can be accessed by any code in the same assembly, but not from another assembly.
- protected internal: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
- private protected: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
<hr>

### Static Modifier

``` public static int InstanceCount { get; set; }```

The static modifier defines members that belong to the class itself and not to an instance of that class. 

- A static class cannot be instantiated with `new`
- access members using the class name
- members must also be declared static
- often used as a container for utility methods
- the `StringHandler` is a static class example.

```
c1.FirstName = "Bilbo";
Customer.InstanceCount += 1;
 ```
 <hr>

## Relationships

- Collaboration ("uses a")
- Composition ("has a")
    - ex) customer has an address.
    - aggregation (multiple items that can exist without its parent)
    - composition (object owns the related objects and delete cascades)
- Inheritance ("is a")

## Inheritance
By default, class members are sealed and cannot be overridden
You can expose members using:
- abstract
    - method signature as place holder with no implementation
    - only use in abstract classes
    - must be overridden by derived class
- virtual
    - method with default implementation
    - use in abstract or concrete classes
    - optionally overridden by derived class

## Extention Method

```
public static class StringHandler
{
    public static string InsertSpaces(string source){
        ...
    }

    // using the method:
    return StringHandler.InsertSpaces(productName);

```

```
public static class StringHandler
{
    pblic static string InsertSpaces(this string source)
    { ...
    }

    // using the method:
}   return _productName.InsertSpaces()
```