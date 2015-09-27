var PluginSDK = (function () {

    var _self = {
        Initialize: Initialize,
    }

    function Initialize(applicationId) {
        if (applicationId == null || applicationId == undefined) {
            console.log("ApplicationId is a required parameter.");
            return;
        }

        //Try to load the plugins
        var divElement = $(".staywell-centers");
        if (divElement != null) {
            CenterPlugin.Initialize(divElement, applicationId);
        }
    }

    return _self;

}());