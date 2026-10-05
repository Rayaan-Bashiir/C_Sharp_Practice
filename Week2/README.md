# Chapter 2: Processing Data

## Topics

- 3.1 Reading Input with TextBox Controls
- 3.2 A First Look at Variables
- 3.3 Numeric Data Types and Variables
- 3.4 Performing Calculations
- 3.5 Inputting and Outputting Numeric Values
- 3.6 Formatting Numbers with the ToString Method
- 3.7 Simple Exception Handling
- 3.8 Using Named Constants

## 1. Reading Input with TextBox

A `TextBox` lets the user type data with the keyboard. Whatever the user types is stored in its `Text` property, and it is always a **string**.

Three ways to clear a TextBox:

```csharp
nameTextBox.Text = "";
nameTextBox.Text = string.Empty;
nameTextBox.Clear();
```

## 2. Variables

A **variable** is a named place in memory that stores a value. You must declare it before using it:

```csharp
DataType variableName;
```

**Naming rules:**

- Start with a letter or an underscore.
- No spaces.
- Cannot be a C# keyword.
- Choose a meaningful name, such as `firstName`.

**Other ideas about variables:**

- **Primitive data types** are the basic types built into C#, such as `string` and `int`.
- **Initialization** means giving a variable its first value. C# will not compile code that uses a variable with no value.
- **Assignment compatibility:** you can only store a value that matches the variable's type.
- You can declare several variables of the same type in one line: `string firstName, lastName;`

## 3. Strings and Concatenation

A `string` holds text such as a name or a phone number. **Concatenation** joins strings together using the `+` operator.

```csharp
string fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
fullNameLabel.Text = fullName;
```

## 4. Scope and Lifetime

- A **local variable** is declared inside a method and can only be used inside that method.
- **Scope** is the part of the program where a variable can be used.
- **Lifetime** is the time the variable exists in memory. It is created when the method starts and destroyed when the method ends.
- You cannot declare two variables with the same name in the same scope, but different methods can use the same name.

## 5. Numeric Data Types

| Type | Stores | Example |
|---|---|---|
| `int` | Whole numbers | `int hours = 40;` |
| `double` | Numbers with a fractional part | `double temperature = 87.6;` |
| `decimal` | Fractional numbers with high precision, used for money | `decimal payRate = 28.75m;` |

- A **numeric literal** is a number written directly in the code. A decimal literal needs `m` after it.
- Compatibility: an `int` can go into a `double` or a `decimal`, but a `double` cannot go into an `int` or a `decimal` without conversion.
- **Casting** converts one type to another: `int whole = (int)moneyNumber;`
- **`var`** lets the compiler choose the type from the value: `var rate = 12.0;` (it needs a starting value and works only for local variables).

## 6. Calculations

| Operator | Meaning |
|---|---|
| `+` | Addition |
| `-` | Subtraction |
| `*` | Multiplication |
| `/` | Division |
| `%` | Remainder (modulus) |

- Use parentheses to control the order: `result = (a + b) / 4;`
- With mixed types, an `int` mixed with a `double` gives a `double`, and an `int` mixed with a `decimal` gives a `decimal`. Mixing `double` and `decimal` is not allowed.
- **Integer division:** dividing two integers gives an integer, so `7 / 2` is `3`. To get `3.5`, cast one value: `(double)7 / 2`.

## 7. Numeric Input and Output

Text typed in a TextBox is a string, so it must be converted before you calculate. A cast cannot do this, so use `Parse`:

```csharp
int hours = int.Parse(hoursTextBox.Text);
double rate = double.Parse(rateTextBox.Text);
decimal pay = decimal.Parse(payTextBox.Text);
```

To show a number in a Label or TextBox, convert it back to a string:

```csharp
totalLabel.Text = total.ToString();
```

## 8. Formatting with ToString

| Format | Meaning | Example | Result |
|---|---|---|---|
| `"N"` | Number with commas | `12.3.ToString("n3")` | 12.300 |
| `"F"` | Fixed number of decimals | `123456.0.ToString("f2")` | 123456.00 |
| `"E"` | Exponential | `123456.0.ToString("e3")` | 1.235e+005 |
| `"C"` | Currency | `1234.5.ToString("C")` | $1,234.50 |
| `"P"` | Percentage | `0.234.ToString("P")` | 23.40% |

## 9. Exception Handling

An **exception** is an unexpected error that happens while the program runs, such as typing letters where a number is needed or dividing by zero. If it is not handled, the program stops suddenly.

- The `try` block holds the code that might fail.
- The `catch` block holds what to do when it fails.
- **Throwing** means the error happens. **Catching** means the program handles it.

```csharp
try
{
    double miles = double.Parse(milesTextBox.Text);
    resultLabel.Text = (miles * 1.6).ToString("F2");
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

Every exception is an object, and its `Message` property describes the error.

## 10. Named Constants

A **named constant** is a name for a value that never changes while the program runs. It is declared with `const`:

```csharp
const double INTEREST_RATE = 0.129;
```

By tradition, constant names are written in capital letters.