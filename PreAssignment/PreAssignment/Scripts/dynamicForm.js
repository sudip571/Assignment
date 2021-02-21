var formDataArray = [];

var divClass = "";
var inputClass = "";
var parentEementId = "";
var formDiv = "";

function generateDynForm(dataArray, elementId) {
    parentEementId = '$("#' + elementId + '")';
    var elId = '#' + elementId;
    for (var i = 0; i < dataArray.length; i++) {
        
        var data = dataArray[i];
        generateIndividualField(data);
        
        $(elId).append(formDiv);
    }
    // Add submit button
    var submitBtn = $('<div class="form-group"><input type="submit" value="Save" id="formSubmit" class="btn btn-primary" /></div>');
    $(elId).append(submitBtn);
}

//function generateFormSegment(data) {

//}

function generateIndividualField(data) {
    
    formDiv = $('<div class="form-group"></div>');
    var label = $('<label></label>');
    switch (data.Type) {
        case 'Number':
            label.html(data.Field);
            formDiv.append(label);
            var input = $('<input class="form-control">');
            input.attr("type", data.Type);
            input.attr("min", data.Min_Value);
            input.attr("name", data.Field);
            formDiv.append(input);
        break;
        case 'text':
        case 'Text':
            label.html(data.Field);
            formDiv.append(label);
            var inputText = $('<input class="form-control">');
            inputText.attr("type", data.Type);
            inputText.attr("maxlength", data.Max_Length);
            inputText.attr("name", data.Field);
            formDiv.append(inputText);
            break;
        case 'LongText':
            label.html(data.Field);
            formDiv.append(label);
            var textArea = $('<textarea class="form-control">');            
            textArea.attr("maxlength", data.Max_Length);
            textArea.attr("name", data.Field);
            formDiv.append(textArea);
            break;
        case 'DropDownList':
            label.html(data.Field);
            formDiv.append(label);
            var select = $('<select class="form-control">');
            select.attr("name", data.Field);
            var options = data.Allowed_Values;
            for (var i = 0; i < options.length; i++) {
                var optionElement = $('<option>');
                optionElement.attr("value", options[i]);
                optionElement.html(options[i]);
                select.append(optionElement);
            }            
            formDiv.append(select);
            break;
        case 'RadioButton':
            label.html(data.Field);
            formDiv.append(label); 
            var radioOptions = data.Allowed_Values;
            for (var j = 0; j < radioOptions.length; j++) {
                var radioDiv = $('<div class="form-check">');
                var radioInput = $('<input class="form-check-input" type="radio">');
                radioInput.attr("name", data.Field);
                radioInput.attr("value", radioOptions[j]);
                var radioLabel = $(' <label class="form-check-label">');
                radioLabel.html(radioOptions[j]);
                radioDiv.append(radioInput);
                radioDiv.append(radioLabel);
                formDiv.append(radioDiv);
            }
            
            break;
        case 'CheckBox':
            label.html(data.Field);
            formDiv.append(label);
            var checkOptions = data.Allowed_Values;
            for (var k = 0; k < checkOptions.length; k++) {
                var checkDiv = $('<div class="form-check form-check-inline">');
                var checkInput = $('<input class="form-check-input" type="checkbox">');                
                checkInput.attr("value", checkOptions[k]);
                var checkLabel = $('<label class="form-check-label">');
                checkLabel.html(checkOptions[k]);
                checkDiv.append(checkInput);
                checkDiv.append(checkLabel);
                formDiv.append(checkDiv);
            }

            break;

        
    }
}