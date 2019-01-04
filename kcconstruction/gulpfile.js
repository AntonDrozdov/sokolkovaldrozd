let gulp = require('gulp');
let sass = require('gulp-sass');

let rimraf = require('rimraf');

let paths = {
    nodeModuleRoot: "./node_modules/",
    webRoot: "./wwwroot/"
};


gulp.task("processingSass", function () {
    return gulp.src('Styles/StyleSheet.scss')
    .pipe(sass())
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task('copyingFontAwesome', function() {
    return gulp.src(paths.nodeModuleRoot + 'font-awesome/**/*')
        .pipe(gulp.dest(paths.webRoot + 'libs/font-awesome/'));
});

gulp.task('cleanFontAwesome', function(callback) {
    rimraf(paths.webRoot + 'libs/font-awesome', callback);
});