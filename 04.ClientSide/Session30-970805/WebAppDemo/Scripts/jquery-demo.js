$('#save-btn').on('click', function () {
    $('<tr>')
        .append($('<td>').html($('#task-name').val()))
        .append($('<td>').html($('#task-due-date').val()))
        .append($('<td>').append($('<button>').html('<span class="glyphicon glyphicon-ok"></span>')))
        .appendTo($('#tasks-table-body'));
});