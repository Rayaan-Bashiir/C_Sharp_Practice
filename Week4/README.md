# Chapter 3 – Making Decisions (Part 2)

## 5. Boolean Variables and Flags

A Boolean variable stores one of two values: `true` or `false`.

A flag is a Boolean variable used to indicate whether a condition has occurred.

```csharp
bool isRegistered = true;

if (isRegistered)
{
    MessageBox.Show("Student is registered");
}
```

## 6. Comparing Strings

Strings can be compared using comparison operators such as `==` and `!=`.

- `==` checks if two strings are equal.
- `!=` checks if two strings are different.
- `String.Compare()` compares two strings.

```csharp
string name = "Ali";

if (name == "Ali")
{
    MessageBox.Show("Names are equal");
}
```

## 7. TryParse Method

The `TryParse()` method converts text into a numeric value safely.

Common methods include:

- `int.TryParse()`
- `double.TryParse()`
- `decimal.TryParse()`

The `out` keyword is used to receive the converted value.

```csharp
string ageText = "21";
int age;

if (int.TryParse(ageText, out age))
{
    MessageBox.Show(age.ToString());
}
else
{
    MessageBox.Show("Invalid number");
}
```

## 8. Input Validation

Input validation checks whether the data entered by the user is valid.

It helps prevent incorrect values from being processed.

```csharp
int score = 85;

if (score >= 0 && score <= 100)
{
    MessageBox.Show("Valid Score");
}
else
{
    MessageBox.Show("Invalid Score");
}
```

## 9. RadioButtons and CheckBoxes

RadioButtons and CheckBoxes allow users to select options.

Important properties and events:

- `Text`: Gets or sets the displayed text.
- `Checked`: Checks whether an option is selected.
- `CheckedChanged`: Occurs when the Checked property changes.

```csharp
if (radioButton1.Checked)
{
    MessageBox.Show("RadioButton selected");
}

if (checkBox1.Checked)
{
    MessageBox.Show("CheckBox selected");
}
```

## 10. Switch Statement

The `switch` statement selects one block of code from multiple possible cases.

Important keywords:

- `switch`: Starts the selection structure.
- `case`: Defines a possible value.
- `break`: Ends a case.
- `default`: Runs when no case matches.

```csharp
int choice = 2;

switch (choice)
{
    case 1:
        MessageBox.Show("Home");
        break;

    case 2:
        MessageBox.Show("Settings");
        break;

    default:
        MessageBox.Show("Invalid Choice");
        break;
}
```

## 11. ListBox

A ListBox displays a list of items and allows users to select items.

Important properties:

| Property | Description |
|---|---|
| `Text` | Gets or sets the text |
| `Items` | Contains the list items |
| `Items.Count` | Returns the number of items |
| `SelectedItem` | Returns the selected item |
| `SelectedIndex` | Returns the index of the selected item |

Important methods:

| Method | Description |
|---|---|
| `Items.Add()` | Adds an item |
| `Items.Remove()` | Removes an item |
| `Items.RemoveAt()` | Removes an item using its index |
| `Items.Clear()` | Removes all items |

**Important Notes:**

- ListBox indexes start at `0`.
- If no item is selected, `SelectedIndex` returns `-1`.

Example:

```csharp
listBox1.Items.Add("Ali");
listBox1.Items.Add("Ahmed");

listBox1.Items.Remove("Ali");

listBox1.Items.Clear();
```

---

**End of Chapter 3 – Making Decisions.**