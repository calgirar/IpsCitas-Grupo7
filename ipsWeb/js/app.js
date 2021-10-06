$('document').ready(function(){
    if ( $( "#cita-form" ).length ) {
        var clicked;

        function daysInMonth (month, year) {
            return new Date(year, month, 0).getDate();
        }
        var daysJump = {
            "Sunday": 0,
            "Monday": 1,
            "Tuesday": 2,
            "Wednesday": 3,
            "Thursday": 4,
            "Friday": 5,
            "Saturday": 6,

        };
        var dateToday = new Date();
        var dateMonth  = dateToday.getFullYear()+'-'+(dateToday.getMonth()+1)+'-'+1;
        var firstDay = new Date(dateMonth).toLocaleDateString("en-US", { weekday: 'long' });
        
        var monthLength = daysInMonth((dateToday.getMonth()+1), dateToday.getFullYear());

        var htmlToAppend = "";

        for (let i = 0; i < daysJump[firstDay]; i++) {
            htmlToAppend = htmlToAppend + "<div></div>";
        }
        for (let i = 1; i < monthLength + 1; i++) {
            htmlToAppend = htmlToAppend + '<div class="cd-day" id="day_'+i+'">'+i+'</div>';
        }

        $( "#calendar-days" ).append( $( htmlToAppend ) );

        $('.cd-day').click(function() {
            if (clicked != null){
                $(clicked).removeClass("cd-current");
            }
            clicked = this

            var clicked_day = this.id
            const cb_id = clicked_day.split("_");
            clicked_day = cb_id[1]

            $(this).addClass("cd-current");

            var selected_date = dateToday.getFullYear()+'-'+(dateToday.getMonth()+1)+'-'+ clicked_day.padStart(2, "0");

            console.log(selected_date);

            $('#caledar-date').val(selected_date);
        });

        $("#caledar-date").change(function() {
            console.log("cambio");
        });
    }
});