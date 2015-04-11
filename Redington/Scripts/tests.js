QUnit.test("Calculation - CombinedWith - 0.5 and 0.5", function (assert) {
    var result = Calculation(0.5, 0.5, '0');
    var expected = 0.25;
    assert.equal(result, expected, "The result should be 0.25");
});

QUnit.test("Calculation - Either - 0.5 and 0.5", function (assert) {
    var result = Calculation(0.5, 0.5, '1');
    var expected = 0.75;
    assert.equal(result, expected, "The result should be 0.75");
});

QUnit.test("Calculation - CombinedWith - undefined and 0.6", function (assert) {
    var result = Calculation(undefined, 0.6, '1');
    var expected = -1;
    assert.equal(result, expected, "The result should be -1");
});

QUnit.test("Calculation - missing type - 0.1 and 1", function (assert) {
    var result = Calculation(0.1, 1, undefined);
    var expected = -1;
    assert.equal(result, expected, "The result should be -1");
});

QUnit.asyncTest("Saving result - success", function () {
    $.ajax({
        url: '/Home/SaveResults',
        contentType: 'application/json',
        type: 'POST',
        data: JSON.stringify({ probabilityOne: 0.5, probabilityTwo: 0.5, selectedOption: '0', result: 0.25 }),
        success: function (data) {
            ok(true, "The result should be success");
            start();
        }
    });
});

QUnit.asyncTest("Saving result - error", function () {
    $.ajax({
        url: '/Home/SaveResults',
        contentType: 'application/json',
        type: 'POST',
        data: JSON.stringify({ probabilityOne: '', probabilityTwo: 0.5, selectedOption: '0', result: 0.25 }),
        success: function (data) {
        },
        error: function () {
            ok(true, "The result should be error");
            start();
        }
    });
});