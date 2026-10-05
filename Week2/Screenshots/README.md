# Chapter 2 Practice: Processing Data in C#

## Declaring, Initializing, and Joining Variables

A variable is declared with its data type, then given a value. Several variables of the same type can be declared in one statement. The `+` operator joins strings together, and it can also join a string with a number.

### Code

```csharp
private void declareButton_Click(object sender, EventArgs e)
{
    // Declare a variable
    int score;

    // Declare several string variables in one statement
    string firstName, lastName, fullName;

    // Give the variables their values
   Number = 4;
    firstName = "Rayaan";
    lastName = "Bashiir";

    // Join the strings with a space between them
    fullName = firstName + " " + lastName;

    // Show the result in a label
    infoLabel.Text = fullName + " scored " + score;
}
```

## Using a Local Variable

A variable declared inside a method is a **local variable**. It can only be used inside that method, and it is destroyed when the method ends.

### Code

```csharp
private void localButton_Click(object sender, EventArgs e)
{
    // This variable exists only inside this method
    int age = 10;

    MessageBox.Show("Age is " + age);
}
```

## Numeric Types, Casting, and Calculations

`int` stores whole numbers, `double` stores numbers with decimals, and `decimal` stores precise values such as money (note the `m` after the number). A cast such as `(int)` converts one type to another. With two integers, the `/` operator performs integer division, and `%` gives the remainder.

### Code

```csharp
private void numericButton_Click(object sender, EventArgs e)
{
    // Numeric data types
    int quantity = 22;
    double price = 1.7;
    decimal salary = 400.50m;

    // Type casting: the decimal part is dropped
    int wholeSalary = (int)salary;

    // Calculations with two integers
    int a = 30;
    int b = 6;
    int sum = a + b;            // 36
    int difference = a - b;     // 24
    int product = a * b;        // 180
    int quotient = a / b;       // 5 (integer division)
    int remainder = a % b;      // 0

    MessageBox.Show("Quotient: " + quotient + ", Remainder: " + remainder);
}

`
private void constantButton_Click(object sender, EventArgs e)
{
    // A value that never changes
    const double TAX_RATE = 0.15;

    double price = 200;
    double tax = price * TAX_RATE;

    taxLabel.Text = tax.ToString("F2");    // 30.00
}
```