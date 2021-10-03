  var HeadspacePlugin = {
      PopupMaker : function(text)
      {
        if (confirm(text)) {
	        alert("Привет!");
	    } else {
	        alert("Вы нажали кнопку отмена")
	    }
        return 1;
      },
      AlertMaker : function(text)
      {
	    alert(text);
      },
      ConfirmMaker : function()
      {
        if (confirm("Oh no! Looks like the level didn't load properly. Would you like to continue anyway?")) {
	        alert("Alright! Just be careful, things might get a bit unstable :<)");
            return 1;
	    } else {
	        alert("Reloading failed. Looks like you'll have to play the unstable version until the error gets resolved.")
            return 0;
	    }
      },
      ConfirmMaker2 : function()
      {
        if (confirm("Aaaand it crashed... Turns out it was too unstable to be played. Good enough for Steam. Someone is going to buy this for a dollar! Anyway, would you like to rate my game?")) {
	        alert("All 5 Star for sure");
            return 1;
	    } else {
	        alert("Voidsay will remember this.")
            return 0;
	    }
      }
    };
mergeInto(LibraryManager.library, HeadspacePlugin);

