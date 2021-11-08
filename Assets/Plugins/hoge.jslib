mergeInto(LibraryManager.library, {

  Fuga: function() {
    console.log("fuga")
  },

  HogeHoge: function() {
    window.unityMethods.sampleHoge();
  },

  DisplayModal: function() {
  	window.unityMethods.displayModal();
  },

  HiddenModal: function() {
  	window.unityMethods.hiddenModal();
  }

});