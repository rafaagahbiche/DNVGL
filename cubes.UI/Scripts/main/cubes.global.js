var setCalculateIntersection = function () {
    if ($('#cubes-space').children().length == 2) {
        $('a.add-link').addClass('disabled');
        $('a.calculate-intersection').removeClass('disabled');
    }
}

var bindAddArticleTabEvent = function () {
	$('a.calculate-intersection').bind('click', function (e) {
		var cubes = [];
		$('#cubes-space').children().each(function () {
			var cube = {
				X: $(this).find('#X').val(),
				Y: $(this).find('#Y').val(),
				Z: $(this).find('#Z').val(),
				Width: $(this).find('#Width').val()
		};
			cubes.push(cube);
		});

		var cubesSpace = {
			Cubes: cubes
		};

		$.ajax({
			url: this.href,
			type: "POST",
			data: cubesSpace,
			success: function (data) {
			    $(data).insertAfter("#cubes-space");
			}
		});

		e.preventDefault();
	});
}

$(function () {
	bindAddArticleTabEvent();
});