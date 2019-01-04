let gulp = require("gulp");
let fs = require("fs");
let sass = require("gulp-sass");
let rimraf = require("rimraf");
let paths = {
    nodeModuleRoot: "./node_modules/",
    webRoot: "./wwwroot/"
};


gulp.task("processingKCSass", function () {
    return gulp.src("Styles/KCStyleSheet.scss")
    .pipe(sass())
        .pipe(gulp.dest("wwwroot/css"));
});
gulp.task("processingKCJs", function () {
    return gulp.src("Scripts/KCScripts.js")
        .pipe(gulp.dest("wwwroot/js"));
});

gulp.task('copyingFontAwesome', function() {
    return gulp.src(paths.nodeModuleRoot + "font-awesome/**/*")
        .pipe(gulp.dest(paths.webRoot + "libs/font-awesome/"));
});

gulp.task('cleanFontAwesome', function(callback) {
    rimraf(paths.webRoot + "libs/font-awesome", callback);
});