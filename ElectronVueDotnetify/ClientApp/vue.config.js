module.exports = {
    devServer: {
        proxy: {
            '/dotnetify': {
            target: 'http://localhost:5000'
            }
        }
    },
    configureWebpack: {
        target: 'electron-renderer',
      }
};