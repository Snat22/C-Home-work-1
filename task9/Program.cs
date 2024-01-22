int Pow(int num){
    if(num <= 1) {

        return 1;
    }else{
        return num * Pow(num);
    }
}