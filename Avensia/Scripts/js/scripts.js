$(function() { 


			/*$(window).bind('exitBreakpoint320',function() {
				$('#log').append('<p>Exiting 320 breakpoint</p>');
			});
			$(window).bind('enterBreakpoint320',function() {
				$('#log').append('<p>Entering 320 breakpoint</p>');
			});

			$(window).bind('exitBreakpoint480',function() {
				$('#log').append('<p>Exiting 480 breakpoint</p>');
			});
			$(window).bind('enterBreakpoint480',function() {
				$('#log').append('<p>Entering 480 breakpoint</p>');
			});
			$(window).bind('exitBreakpoint768',function() {
				$('#log').append('<p>Exiting 768 breakpoint</p>');
			});
			$(window).bind('enterBreakpoint768',function() {
				$('#log').append('<p>Entering 768 breakpoint</p>');
			});

			$(window).bind('exitBreakpoint1024',function() {
				$('#log').append('<p>Exiting 1024 breakpoint</p>');
			});
			$(window).bind('enterBreakpoint1024',function() {
				$('#log').append('<p>Entering 1024 breakpoint</p>');
			});
			$(window).setBreakpoints();

			$('#distinct').bind('click',function() {
				$(window).resetBreakpoints();
				$(window).setBreakpoints({distinct: $('#distinct').is(":checked")});
				$(window).resize();
			});
*/


    $(window).bind('enterBreakpoint320',function() {
	    $("footer h2").on("click",function() {
	        $(this).next().toggle();
	    });	
	    $("#searchbox").off("focus");
		    $("#searchbox").on("focus",function(){
	            $(".autocomplete").show();
	            $(this).val("bl");
	        });
            
        $(".main_nav li").on("click",function(e) {
	    
	        e.preventDefault();
	        var i = $(this).index();
	    
	    
	        $("#flyouts").show();
	    
	    
	        var u = $("#flyouts .sub-menu:eq("+i+")"),
	        uls = $("#flyouts ul");

	        //$(this).css({"padding-bottom":u.height()})
	    
	        uls.hide();
	        u.show();
	    
	    
u.css({"position": "fixed",
"background": "white",
"width": "85%",
"top": "58px",
"height": "100%"});
	    
	    
	    
	    });
	
	$(".menu-toggle").on("click", function() {
	
	    $("#flyouts").addClass("mobile");
	    
	    $(this).toggleClass("active");
	    
	    if( $(this).hasClass("active")) {	    
	    $("body").css({
	        "position":"absolute",
	        "left":"85%"
	    });
	    
	    $(".tm").css({
	        "position":"fixed",
	        "top":"50px",
	        "display": "block",
	        "width": "85%"
	    });
	    
        $(".tm .tmi").css({
	        "display": "block"
	        
	    });
	    
	     $(".main_nav").css({
	        "position": "static",
	        "width": "100%"
	    });
	    
	     $(".main_nav li").css({
	        "background": "none"
	
	    });
	    
	    $(".main_nav li a").css({
	        "color":"black"
	    });
	    
	    
	    $("#main_nav").off();
	    
	    $(".tm").off();
	    
	    }
	    else {
	         $("body").css({
	            "position":"static"
	        });
	        $(".tm").css({
    	        "display": "none"
	        });
	    }
	    
	
	});
        
	});
	
	$(window).bind('exitBreakpoint320',function() {
		$("footer h2").off();
		$("footer h2").next().show();
		$("#searchbox").off("focus");
		$("#searchbox").on("focus",function(){
	        var l = $(".search").position().left;
	        var m = $(".search").css("marginLeft");
	        $(".autocomplete").css({"left":l,"margin-left":m}).show();
	        $(this).val("bl");
	    });
	   
		    
	});
	
	$(window).bind('enterBreakpoint1024',function() {
	    
	    desktopmenu();
	
	});
	$(window).bind('enterBreakpoint768',function() {
	    
	    desktopmenu();
	
	});
	
	$(window).setBreakpoints();
	
	var desktopmenu = function() {
	
	    
	    /* Menu */
	    $(".tm").hoverIntent({
            over: makeTall,
            out: makeShort,
            selector: '.articles',
            timeout:200
        });
    
        function makeTall(){
            $("#main_nav").show();        
        }
    
	    function makeShort() {        
            $("#main_nav").hide();
            $("#flyouts").hide();
        }
    
        $("#main_nav").menuAim({
            activate: function(a){
                var idx = $(a).index();
                $("#flyouts").show();

                $('#flyouts ul.sub-menu').eq(idx).show();
        
        
            },  // fired on row activation
            deactivate: function(a){
                var idx = $(a).index();
                $('#flyouts ul.sub-menu').eq(idx).hide();
        

            }  // fired on row deactivation
        });
	    
	};
	
	
    
    /* Instant search */
	$("#searchbox").on("blur",function(){
	    $(".autocomplete").hide();
	    $(this).val("Hej,vad letar du efter");
	});
	 $("#searchbox").on("focus",function(){
	            var l = $(".search").position().left;
	            var m = $(".search").css("marginLeft");
	            $(".autocomplete").css({"left":l,"margin-left":m}).show();
	            $(this).val("bl");
	        });

	    
	$('.nav-tabs').tab();
	
	$(".tmi").on("click", function() {
	    
	    $(".main_nav",this).show();
	});
	
	
	
	
	
	
	
});