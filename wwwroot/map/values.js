var svgMapDataCovid = {
  data: {
    confirmed: {
      name: 'confirmed',
      format: '{0} cases',
      thousandSeparator: ',',
      thresholdMax: 500000,
      thresholdMin: 1000
    },
    recovered: {
      name: 'recovered',
      format: '{0} cases',
      thousandSeparator: ',',
      thresholdMax: 500000,
      thresholdMin: 1000
    },
    critical: {
      name: 'critical',
      format: '{0} cases',
      thousandSeparator: ',',
      thresholdMax: 500000,
      thresholdMin: 1000
    },
    deaths: {
      name: 'deaths',
      format: '{0} cases',
      thousandSeparator: ',',
      thresholdMax: 500000,
      thresholdMin: 1000
    }
  },
  applyData: 'confirmed',
  values: {}
}

var xmlhttp = new XMLHttpRequest();
var url = "https://coronavirus-19-api.herokuapp.com/countries";

xmlhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        var res = JSON.parse(this.responseText);
        for(var item of res){
          for (var i in svgMap.prototype.countries) {
            if(item.country == "USA"){
              svgMapDataCovid.values["US"] = {confirmed: item.cases, recovered: item.recovered, critical: item.critical , deaths: item.deaths};
              break;
            }
            if (svgMap.prototype.countries.hasOwnProperty(i)) {
              if(item.country == svgMap.prototype.countries[i]){
                svgMapDataCovid.values[i] = {confirmed: item.cases, recovered: item.recovered, critical: item.critical , deaths: item.deaths}
              }
            }
          }
        }
    }
};
xmlhttp.open("GET", url, true);
xmlhttp.send();