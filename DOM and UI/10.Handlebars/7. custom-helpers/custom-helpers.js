(function () {
    Handlebars.registerHelper('list', function (items, options) {
        var html = '<ul class="list">',
            item,
            index;
        for (index in items) {
            item = items[index];
            html += '<li class ="list-item">' + options.fn(item) + '</li>';
        }
        return html;
    });
    var courses=[{
        name: 'JavaScript Fundentals',
		description: 'JavaScript basics, syntax, loops, functions, conditionals'
	}, {
		name: 'JavaScript UI & DOM',
		description: 'Web graphics, HTML5 Canvas, SVG, Animations, DOM and DOM operations, Event Model, jQuery, HTML Templates,'
	}, {
		name: 'JavaScript OOP',
		description: 'Creating modular apps using JavaScript, function contructors, prototypal and classical (functional) inheritance, modules'
	}, {
		name: 'JavaScript Applications',
		description: 'Asyncronius execution with callbacks and promises, HTTP and AJAX, application architecture'
	}, {
		name: 'SPA applications with JavaScript',
		description: 'KendoUI, AngularJS, App clouds'
    }];
    document.getElementById('courses').innerHTML=Handlebars.compile(document.getElementById('course-item-template').innerHTML)({
       courses:courses 
    });
} ());