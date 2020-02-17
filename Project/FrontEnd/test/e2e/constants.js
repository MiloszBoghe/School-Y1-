var TestConstants = function() {
    this.HOST = 'http://localhost:63343/Mastermind';
    this.LOGIN_PAGE_URL = this.HOST + '/login/login.html';
    this.REGISTRATION_PAGE_URL = this.HOST + '/register/register.html';
    this.LOBBY_PAGE_URL = this.HOST + '/mastermind/lobby.html';

    this.NICKNAME = 'victor';
    this.EMAIL = 'victor@student.pxl.be';
    this.PASSWORD = 'Test123!';
};

module.exports = new TestConstants();