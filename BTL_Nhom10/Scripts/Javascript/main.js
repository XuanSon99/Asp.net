$(document).ready(function(){
    addEventListener('scroll',function(){
        const x = $(window).scrollTop()
        if(x > $('.special-pro').offset().top - 600){
            $('.special-pro').css('opacity','1')
        }
        else{
            $('.special-pro').css('opacity','0')
        }
        if(x > $('.new-pro').offset().top - 600){
            $('.new-pro').css('opacity','1')
        }
        else{
            $('.new-pro').css('opacity','0')
        }
        if(x > $('.main-banner').offset().top - 600){
            $('.main-banner').css('opacity','1')
        }
        else{
            $('.main-banner').css('opacity','0')
        }
        if(x > $('.main-content .banner').offset().top - 800){
            $('.main-content .banner').css({'opacity':'1','margin-top':'20px'})
        }
        else{
            $('.main-content .banner').css({'opacity':'0','margin-top':'200px'})
        }
        if(x > $('#sidebar').offset().top - 600){
            $('#sidebar').css({'opacity':'1','margin-left':'0'})
        }
        else{
            $('#sidebar').css({'opacity':'0','margin-left':'-150%'})
        }
        if(x > $('.accessories').offset().top - 700){
            $('.accessories').css({'opacity':'1','margin-top':'25px'})
        }
        else{
            $('.accessories').css({'opacity':'0','margin-top':'200px'})
        }
    })
})