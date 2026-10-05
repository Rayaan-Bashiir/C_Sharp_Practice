# Chapter 1 Practice: Event Handlers in C#

## Showing a Message with `MessageBox`

Clicking the **Click Me** button triggers the `myButton_Click` event handler. It pops up a small window that says **Thanks for clicking the button!**

### Code

```csharp
private void myButton_Click(object sender, EventArgs e)
{
    // Show a message to the user
    MessageBox.Show("Thanks for clicking the button!");
}
```

## Changing the Text of a Label

This example shows how a button can change what a Label displays.

Pressing the **Show Answer** button runs `showAnswerButton_Click`, which sets the text of `answerLabel` to:

**Jamhuuriya University**

### Code

```csharp
private void showAnswerButton_Click(object sender, EventArgs e)
{
    // Put the text inside the label using its Text property
    answerLabel.Text = "Jamhuuriya University";
}
```

## Making Pictures Clickable

A `PictureBox` can respond to clicks just like a button. Double clicking it in the Designer creates its Click event, and then you write the code inside.

Here, clicking the logo displays a welcome message, while clicking the student picture makes it disappear by setting its `Visible` property to `false`.

### Code

```csharp
private void logopicturebox_Click(object sender, EventArgs e)
{
    // Show a welcome message when the logo is clicked
    MessageBox.Show("welcome best class");
}

private void studentpicturebox_Click(object sender, EventArgs e)
{
    // Hide the student picture
    studentpicturebox.Visible = false;
}
```

## Closing the Form

Pressing the **Exit** button runs `exitButton_Click`, which shuts the window using `this.Close()`.

### Code

```csharp
private void exitButton_Click(object sender, EventArgs e)
{
    // Close the form
    this.Close();
}
```