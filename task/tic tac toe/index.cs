*{
    margin: 0;
    padding: 0;
    list-style: none;
    text-decoration: none;
    box-sizing: border-box;
    font-family: poppins;
  }
  :root{
    --main-bg: #312c53;
    --secondary-bg: #818FB4;
    
    --white-text: #F5F7F8;
    --black-text: #2b2b2b;
  }
  body{
    width: 100%;
    height: 100%;
    background-color: var(--main-bg);
  }
  /********************************************************************* INTRO PART **************************************************************************/
  .select-box, .play-board, .result-box{
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    transition: all 0.3s ease;
  }
  .select-box{
    width: 700px;
    background: var(--white-text);
    padding: 20px 25px 25px;
    text-align: center;
    border-radius: 12px;
  }
  .select-box.hide{
    opacity: 0;
    pointer-events: none;
  }
  .select-box header{
    font-size: 40px;
    font-weight: 800;
    margin-bottom: 1rem;
  }
  .select-box .title{
    font-size: 22px;
    font-weight: 400;
    margin-bottom: 1rem;
  }
  .select-box .options{
    display: flex;
    justify-content: center;
    align-items: center;
  }
  .options button{
    font-size: 20px;
    font-weight: 600;
    padding: .6rem 3rem;
    border: none;
    background: var(--main-bg);
    border-radius: 5px;
    color: #fff;
    outline: none;
    cursor: pointer;
    transition: all 0.3s ease;
  }
  .options button:hover,
  .btn button:hover{
    background-color: var(--secondary-bg);
    color: var(--main-bg);
    transform: scale(0.96);
  }
  .options button.playerX{
    margin-right: 5px;
  }
  .options button.playerO{
    margin-left: 5px;
  }
  .select-box .credit{
    text-align: center;
    margin-top: 20px;
    font-size: 18px;
    font-weight: 500;
  }
  /**************************************************************** PLAYER BOARD ****************************************************************************/
  .play-board{
    opacity: 0;
    pointer-events: none;
    transform: translate(-50%, -50%) scale(0.9);
  }
  .play-board.show{
    opacity: 1;
    pointer-events: auto;
    transform: translate(-50%, -50%) scale(1);
  }
  .play-board .details{
    padding: 7px;
    border-radius: 5px;
    background: #fff;
  }
  .play-board .players{
    width: 100%;
    display: flex;
    position: relative;
    justify-content: space-between;
  }
  .players span{
    position: relative;
    z-index: 2;
    color: var(--main-bg);
    font-size: 20px;
    font-weight: 500;
    padding: 10px 0;
    width: 100%;
    text-align: center;
    cursor: default;
    user-select: none;
    transition: all 0.3 ease;
  }
  .players.active span:first-child{
    color: #fff;
  }
  .players.active span:last-child{
    color: var(--main-bg);
  }
  .players span:first-child{
    color: #fff;
  }
  .players .slider{
    position: absolute;
    top: 0;
    left: 0;
    width: 50%;
    height: 100%;
    background: var(--main-bg);
    border-radius: 5px;
    transition: all 0.3s ease;
  }
  .players.active .slider{
    left: 50%;
  }
  .players.active span:first-child{
    color: var(--main-bg);
  }
  .players.active span:nth-child(2){
    color: #fff;
  }
  .players.active .slider{
    left: 50%;
  }
  .play-area{
    margin-top: 20px;
  }
  .play-area section{
    display: flex;
    margin-bottom: 1px;
  }
  .play-area section span{
    display: block;
    height: 150px;
    width: 150px;
    margin: 5px;
    color: var(--main-bg);
    font-size: 90px;
    line-height: 150px;
    text-align: center;
    border-radius: 5px;
    background: #fff;
  }
  /***************************************************************** RESULT PAGE ******************************************************************************/
  .result-box{
    padding: 25px 20px;
    border-radius: 5px;
    max-width: 400px;
    width: 100%;
    opacity: 0;
    text-align: center;
    background: #fff;
    pointer-events: none;
    transform: translate(-50%, -50%) scale(0.9);
  }
  .result-box.show{
    opacity: 1;
    pointer-events: auto;
    transform: translate(-50%, -50%) scale(1);
  }
  .result-box .won-text{
    font-size: 30px;
    font-weight: 500;
    display: flex;
    justify-content: center;
  }
  .result-box .won-text p{
    font-weight: 600;
    margin: 0 5px;
  }
  .result-box .btn{
    width: 100%;
    margin-top: 25px;
    display: flex;
    justify-content: center;
  }
  .btn button{
    font-size: 18px;
    font-weight: 500;
    padding: 8px 20px;
    border: none;
    background: var(--main-bg);
    border-radius: 5px;
    color: #fff;
    outline: none;
    cursor: pointer;
    transition: all 0.3s ease;
  }
