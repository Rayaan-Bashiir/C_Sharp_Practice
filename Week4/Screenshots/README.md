# Week 3 practice – Making Decisions (Part 2)

## 5. Boolean Variables (Flags)

A Boolean variable stores two values: `true` or `false`.

```csharp
bool isRegistered = true;

if (isRegistered)
{
    MessageBox.Show("Student is registered");
}
```

## 6. Comparing Strings

Strings can be compared using `==` and `!=` operators.

```csharp
string password = "12345";

if (password == "12345")
{
    MessageBox.Show("Correct Password");
}
```

## 7. TryParse

The `TryParse()` method converts text into a number safely.

```csharp
string ageText = "21";
int age;

if (int.TryParse(ageText, out age))
{
    MessageBox.Show("Age: " + age);
}
```

## 8. Input Validation

Input validation checks whether entered data is within an acceptable range.

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

## 9. RadioButton and CheckBox

The `Checked` property checks whether a RadioButton or CheckBox is selected.

```csharp
if (radioButton1.Checked)
{
    MessageBox.Show("Option 1 selected");
}

if (checkBox1.Checked)
{
    MessageBox.Show("Checkbox is checked");
}
```

## 10. Switch Statement

The `switch` statement selects one option from multiple cases.

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

A ListBox displays a collection of items. We can add, remove, and clear items.

```csharp
listBox1.Items.Add("Ali");
listBox1.Items.Add("Ahmed");

listBox1.Items.Remove("Ali");

listBox1.Items.Clear();
```

**Important Properties:**
- `Items.Count`: Returns the number of items.
- `SelectedItem`: Gets the selected item.
- `SelectedIndex`: Gets the selected item's index.

**Important Methods:**
- `Items.Add()`: Adds an item.
- `Items.Remove()`: Removes an item.
- `Items.RemoveAt()`: Removes an item by index.
- `Items.Clear()`: Removes all items.

---

## Screenshots

Screenshots show the program code and execution results for each topic.

## Conclusion

This week, I practiced Boolean variables, string comparison, TryParse, input validation, RadioButtons, CheckBoxes, switch statements, and ListBox operations in C#.