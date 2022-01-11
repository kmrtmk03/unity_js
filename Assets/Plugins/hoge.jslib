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
  },

  DisplayModalInt: function(_index) {
    window.unityMethods.displayModalInt(_index)
  },

  CompleteLoad: function() {
    window.unityMethodsUnity.completeLoad();
  }

});