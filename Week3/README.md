# Chapter 3 – Making Decisions

## Introduction
This chapter explains how to make decisions in C# programs using decision structures, logical operators, Boolean variables, and different controls.

## Topics Covered

### 1. Decision Structures and if Statement
- A control structure controls the order in which statements execute.
- A decision structure executes statements only when a specific condition is true.
- The `if` statement is used to check a condition.

Example:
```csharp
if (sales > 50000)
{
    bonus = 500;
}
```

### 2. The if-else Statement
- The `if-else` statement executes one block when the condition is true and another block when it is false.

### 3. Nested Decision Structures
- Nested decisions mean placing one `if` statement inside another `if` statement.
- Used to check more than one condition.

### 4. Logical Operators
Logical operators connect or reverse Boolean expressions.

| Operator | Meaning |
|---|---|
| `&&` | AND – Both conditions must be true. |
| `||` | OR – One or both conditions must be true. |
| `!` | NOT – Reverses the condition. |

### 5. bool Variables and Flags
- A `bool` variable stores either `true` or `false`.
- A flag is a variable that indicates whether a condition exists.

### 6. Comparing Strings
- The `==` operator compares two strings.
- The `!=` operator checks if two strings are different.
- `String.Compare()` compares two strings.

### 7. Preventing Data Conversion Exceptions with TryParse
The `TryParse()` methods check whether input can be converted into a specific data type.

Methods:
- `int.TryParse()`
- `double.TryParse()`
- `decimal.TryParse()`

The `out` keyword is used to return the converted value.

### 8. Input Validation
- Input validation checks whether entered data is valid before it is used.
- `TryParse()` checks whether data can be converted.
- Conditions can check whether values are within an acceptable range.

Example:
```csharp
if (testScore >= 0 && testScore <= 100)
{
    // Valid score
}
```

### 9. Radio Buttons and Check Boxes

**RadioButton**
- Allows the user to select one choice from several options.
- Selecting one option automatically deselects the others in the same group.
- Common properties:
  - `Text`
  - `Checked`

**CheckBox**
- Allows the user to select multiple options.
- Common properties:
  - `Text`
  - `Checked`

**CheckedChanged Event**
- Occurs when the `Checked` property changes.
- Used to respond to changes in RadioButton or CheckBox controls.

### 10. The switch Statement
- The `switch` statement selects a path based on the value of a variable or expression.
- It is an alternative to `if-else-if` when checking several possible values.

Important keywords:
- `case`
- `break`
- `default`

### 11. Introduction to List Boxes
A `ListBox` displays a list of items and allows the user to select an item.

Important properties and methods:

| Property / Method | Description |
|---|---|
| `Text` | Gets the text of the selected item. |
| `Items` | Contains the items in the ListBox. |
| `Items.Count` | Gets the number of items. |
| `SelectedItem` | Gets the currently selected item. |
| `SelectedIndex` | Gets the zero-based index of the selected item. |
| `Items.Add()` | Adds an item. |
| `Items.Remove()` | Removes a specific item. |
| `Items.RemoveAt()` | Removes an item using its index. |
| `Items.Clear()` | Removes all items. |

**Important:** ListBox indexes start at `0`. If no item is selected, `SelectedIndex` is `-1`.

## Important C# Keywords and Methods
- `if`
- `else`
- `else if`
- `switch`
- `case`
- `break`
- `default`
- `bool`
- `true`
- `false`
- `int.TryParse()`
- `double.TryParse()`
- `decimal.TryParse()`
- `String.Compare()`
- `CheckedChanged`
- `Items.Add()`
- `Items.Remove()`
- `Items.RemoveAt()`
- `Items.Clear()`

## Conclusion
Chapter 4 teaches how to control program execution using conditions and decision structures. It also explains input validation, logical operators, RadioButtons, CheckBoxes, switch statements, and ListBoxes.