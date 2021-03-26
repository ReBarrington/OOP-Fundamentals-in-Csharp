# Object-Oriented Programming Fundamentals in C#

## The four pillars of object-oriented programming are:
- Abstraction
    - A concept: Simplify reality, ignore extraneous details, focus on what's important for a purpose. 
- Encapsulation
    - A technique: Keeping fields in a class means no other code needs to know/use these details, instead will call a `get()` or `set()` to the class to retrieve information. 
- Inheritance
- Polymorphism

<br>

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