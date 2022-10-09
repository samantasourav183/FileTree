// =======================================================================
    // home Burger menu js start
// =======================================================================
$('.burger, .overlay').click(function(){
  $('.burger').toggleClass('clicked');
  $('.overlay').toggleClass('show');
  $('nav').toggleClass('show');
  $('body').toggleClass('overflow');
});
// ////
 var _gaq = _gaq || [];
  _gaq.push(['_setAccount', 'UA-36251023-1']);
  _gaq.push(['_setDomainName', 'jqueryscript.net']);
  _gaq.push(['_trackPageview']);

  (function() {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
  })();

// =======================================================================
    // dropdown button js start
// =======================================================================

function myFunction() {
  document.getElementById("myDropdown").classList.toggle("show");
}

// Close the dropdown if the user clicks outside of it
window.onclick = function(event) {
  if (!event.target.matches('.dropbtn')) {
    var dropdowns = document.getElementsByClassName("dropdown-content");
    var i;
    for (i = 0; i < dropdowns.length; i++) {
      var openDropdown = dropdowns[i];
      if (openDropdown.classList.contains('show')) {
        openDropdown.classList.remove('show');
      }
    }
  }
}

// =======================================================================
    // tab js start
// =======================================================================
 // tabbed content
    // http://www.entheosweb.com/tutorials/css/tabs.asp
    $(".tab_content").hide();
    $(".tab_content:first").show();

  /* if in tab mode */
    $("ul.tabs li").click(function() {
    
      $(".tab_content").hide();
      var activeTab = $(this).attr("rel"); 
      $("#"+activeTab).fadeIn();    
    
      $("ul.tabs li").removeClass("active");
      $(this).addClass("active");

    $(".tab_drawer_heading").removeClass("d_active");
    $(".tab_drawer_heading[rel^='"+activeTab+"']").addClass("d_active");
    
    });
  /* if in drawer mode */
  $(".tab_drawer_heading").click(function() {
      
      $(".tab_content").hide();
      var d_activeTab = $(this).attr("rel"); 
      $("#"+d_activeTab).fadeIn();
    
    $(".tab_drawer_heading").removeClass("d_active");
      $(this).addClass("d_active");
    
    $("ul.tabs li").removeClass("active");
    $("ul.tabs li[rel^='"+d_activeTab+"']").addClass("active");
    });
  
  
  /* Extra class "tab_last" 
     to add border to right side
     of last tab */
  $('ul.tabs li').last().addClass("tab_last");
  


// =======================================================================
    // modal dropdown js start
// =======================================================================

(function($) {
      $(document).ready(function() {
        var customSelect = $(".custom-select");

        customSelect.each(function() {
          var thisCustomSelect = $(this),
            options = thisCustomSelect.find("option"),
            firstOptionText = options.first().text();

          var selectedItem = $("<div></div>", {
            class: "selected-item"
          })
            .appendTo(thisCustomSelect)
            .text(firstOptionText);

          var allItems = $("<div></div>", {
            class: "all-items all-items-hide"
          }).appendTo(thisCustomSelect);

          options.each(function() {
            var that = $(this),
              optionText = that.text();

            var item = $("<div></div>", {
              class: "item",
              on: {
                click: function() {
                  var selectedOptionText = that.text();
                  selectedItem.text(selectedOptionText).removeClass("arrowanim");
                  allItems.addClass("all-items-hide");
                }
              }
            })
              .appendTo(allItems)
              .text(optionText);
          });
        });

        var selectedItem = $(".selected-item"),
          allItems = $(".all-items");

        selectedItem.on("click", function(e) {
          var currentSelectedItem = $(this),
            currentAllItems = currentSelectedItem.next(".all-items");

          allItems.not(currentAllItems).addClass("all-items-hide");
          selectedItem.not(currentSelectedItem).removeClass("arrowanim");

          currentAllItems.toggleClass("all-items-hide");
          currentSelectedItem.toggleClass("arrowanim");

          e.stopPropagation();
        });

        $(document).on("click", function() {
          var opened = $(".all-items:not(.all-items-hide)"),
            index = opened.parent().index();

          customSelect
            .eq(index)
            .find(".all-items")
            .addClass("all-items-hide");
          customSelect
            .eq(index)
            .find(".selected-item")
            .removeClass("arrowanim");
        });
      });
    })(jQuery);


























