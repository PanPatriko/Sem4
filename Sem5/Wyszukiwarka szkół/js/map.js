	map = new OpenLayers.Map("map");
    map.addLayer(new OpenLayers.Layer.OSM());
	
    epsg4326 =  new OpenLayers.Projection("EPSG:4326"); //WGS 1984 projection
    projectTo = map.getProjectionObject(); //The map projection (Spherical Mercator)
	
    var lonLat = new OpenLayers.LonLat( 19.10771,52.12101).transform( epsg4326, projectTo);
                
    var zoom=6;
	
    var vectorLayer = new OpenLayers.Layer.Vector("Overlay");
	var controls;
	var shools = []; //tablica przechowujądza wszystkie dane o szkołach
	map.addLayer(vectorLayer);
	map.setCenter(lonLat, zoom);

 
    function read_json() {	//
        $.getJSON("js/csvjson.json", function(data) {
            alert("My data: " + data["mydata"]);
            $.each(data["prime"], function(idx,prime) {
                alert("Prime number: " + prime);
            });
        });
    }
	function filterSchools()
	{
		if(map.popups[0]!=null){
			map.removePopup(map.popups[0]);
		}
		createMarkers2();
	}
	
	function drawMarkers() //funkcja rysująca znaczniki
	{
		controls = {
			selector: new OpenLayers.Control.SelectFeature(vectorLayer, { onSelect: createPopup, onUnselect: destroyPopup })
		};
		
		map.addControl(controls['selector']);
		controls['selector'].activate();
	}
	
	function createPopup(feature) {
      feature.popup = new OpenLayers.Popup.FramedCloud("pop",
          feature.geometry.getBounds().getCenterLonLat(),
          null,
          '<div class="markerContent">'+feature.attributes.description+'</div>',
          null,
          true,
          function() { controls['selector'].unselectAll(); }
      );
      map.addPopup(feature.popup);
    }

    function destroyPopup(feature) {
      feature.popup.destroy();
      feature.popup = null;
    }
	
	function createMarkers() //wywoływana tylko raz po wczytaniu pliku csv 
	{
		if(schools.length>0)
		{
			for (var i=1; i<schools.length; i++)
			{				
					if(schools[i][50]!="")
					{
						var desc = "";
						for(var j=0;j<schools[i].length;j++)
						{
							desc = desc + schools[0][j] + ": " + schools[i][j] + '<br>'; 
						}
						feature = new OpenLayers.Feature.Vector(
								new OpenLayers.Geometry.Point( schools[i][50],schools[i][51]).transform(epsg4326, projectTo),
								{description:desc},
								{externalGraphic: 'js/icon40.png', graphicHeight: 40, graphicWidth: 40, graphicXOffset:-12, graphicYOffset:-25   }
								);    
						vectorLayer.addFeatures(feature);
					}					
			}
			document.getElementById("counter").value = "Znalezione szkoły: "+ (schools.length-1) + " Znaczniki " + vectorLayer.features.length;
			drawMarkers();
		}
	}
	function createMarkers2() //funkcja filtrujaca i tworzaca znaczniki
	{
		if(schools.length>0)
		{
			var filter = []; 
			vectorLayer.removeAllFeatures();
			var checkboxes = document.getElementsByName("state");
			for (var i=1; i<schools.length; i++)
			{
				for(var j=0;j<checkboxes.length;j++)
				{
					if(checkboxes[j].checked==true)
					{
						if(schools[i][2]==checkboxes[j].value)
						{
							var address = schools[i][9] + " " + schools[i][16] + " " + schools[i][17];
							if(address.includes(document.getElementById("addr").value)) //filtrowanie po adresie, wielkość znaków ma znaczenie
							{															
								filter.push(schools[i]);
								break;
							}
							else if(schools[i][14].includes(document.getElementById("addr").value)) //filtrowanie po nazwie szkoły, wielkość znaków ma znaczenie
							{
								filter.push(schools[i]);
								break;
							}
						}
					}
				}
			}
			var list = [];
			for(var i=0;i<filter.length;i++) 
			{
				if(filter[i][50]!="")//jeśli pole z koordynatem nie jest puste
				{
					var desc = "";
					for(var j=0;j<filter[i].length;j++)
					{
						desc = desc + schools[0][j] + ": " + filter[i][j] + '<br>';//tekst wyświetlany po kliknieciu w znacznik, shoolls[0] to nazwy kolumn z pliku csv
					}
					feature = new OpenLayers.Feature.Vector( //stworzenie i dodanie znacznika do warstwy
						new OpenLayers.Geometry.Point( filter[i][50],filter[i][51]).transform(epsg4326, projectTo),
						{description: desc},
						{externalGraphic: 'js/icon40.png', graphicHeight: 40, graphicWidth: 40, graphicXOffset:-12, graphicYOffset:-25  }
						);    
					vectorLayer.addFeatures(feature);
				}
				else
				{
					list.push(filter[i])
				}
			}
			if(list.length>0) //wyświetlenie szkół których nie udało sie nanieść na mape
			{
				if(confirm("Nie udało się zlokalizować niektórych szkół na mapie.\nCzy chcesz je zobaczyć?")) {
						for(var i=0;i<list.length;i++)
						{
							var address = list[i][9] + " " + list[i][16] + " " + list[i][17];
							alert("Nie udało się zlokalizować na mapie:\nLp"+list[i][0]+"\n"+list[i][14]+"\n"+address);
						}

					}
			}
			document.getElementById("counter").value = "Znalezione szkoły: "+ filter.length + " Znaczniki " + vectorLayer.features.length;
			drawMarkers();
		}
	}

	function selectAll()//zaznaczenie checkboxów
	{
		var checkboxes = document.getElementsByName("state");

		for(var j=0;j<checkboxes.length;j++)
		{
			if(checkboxes[j].checked==false)
			{
				checkboxes[j].checked=true;
			}
		}			
	}
    function unselectAll()//odznaczenie checkboxów
	{
		var checkboxes = document.getElementsByName("state");

		for(var j=0;j<checkboxes.length;j++)
		{
			if(checkboxes[j].checked==true)
			{
				checkboxes[j].checked=false;
			}
		}	
	}	
	function ReadCSV(files) { //funkcje wywoływana po wybraniu pliku csv
      if (window.FileReader) { //funkcje ponizej wywoływane są po kolei 
          getAsText(files[0]);
      } else {
          alert('FileReader nie jest obsługiwany.');
      }
    }
 
    function getAsText(fileToRead) {
        var reader = new FileReader();
        reader.readAsText(fileToRead);
        reader.onload = loadHandler;
        reader.onerror = errorHandler;
    }
 
    function loadHandler(event) {
        var csv = event.target.result;
		schools = processData(csv); //przypisanie do tablicy odczytanego pliku csv
		createMarkers();
    }
 
    function processData(csv) { //funkcja tworząca tablice z pliku csv
        var allTextLines = csv.split(/\r\n|\n/);
        var lines = [];
        for (var i=0; i<allTextLines.length; i++) {
            var data = allTextLines[i].split(';');
                var tarr = [];
                for (var j=0; j<data.length; j++) {
                    tarr.push(data[j]);
                }
                lines.push(tarr);
        }
        return lines;
    }
    
    function errorHandler(evt) {
        if(evt.target.error.name == "NotReadableError") {
            alert("Nie można odczytać pliku.");
        }}
		
		