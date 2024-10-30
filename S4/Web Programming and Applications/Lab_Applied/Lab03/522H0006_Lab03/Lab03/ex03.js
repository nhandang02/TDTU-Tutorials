function restoreDefault() {
    document.getElementById("message").value = "";
    document.getElementById("color").value = "Black";
    document.getElementById("bold").checked = false;
    document.getElementById("italic").checked = false;
    document.getElementById("underline").checked = false;

    message.style.color = 'Black';
    message.style.fontStyle = 'normal';
    message.style.fontWeight = 'normal';
    message.style.textDecoration = 'none';
}

function updateColor() {
    var selectElement = document.getElementById('color');
    var color = selectElement.options[selectElement.selectedIndex].text;
    var message = document.getElementById('message');
    message.style.color = color;
}

function updateFont() {
    var bold = document.getElementById('bold');
    var italic = document.getElementById('italic');
    var underline = document.getElementById('underline');
    var message = document.getElementById('message');

    var fontWeight = bold.checked ? 'bold' : 'normal';
    var fontStyle = italic.checked ? 'italic' : 'normal';
    var textDecoration = underline.checked ? 'underline' : 'none';

    message.style.fontStyle = fontStyle;
    message.style.fontWeight = fontWeight;
    message.style.textDecoration = textDecoration;
}
