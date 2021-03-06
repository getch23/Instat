# Necessary packages for the Instat Object
packs <- c("openxlsx", "reshape2", "lubridate","plyr", "rtf", "ggplot2", "extRemes", "GGally", "CCA", "plotrix", "agridat", "DAAG", "FactoMineR", "plotrix", "agridat", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "proto", "tidyr", "gridExtra", "tidyr", "ggfortify", "rio", "readxl", "lme4", "dummies")
# Packages including dependencies (generated from miniCRAN package)
packs <- c("openxlsx", "reshape2", "lubridate", "plyr", "rtf", "ggplot2", "extRemes", "GGally", "CCA", "plotrix", "agridat", "DAAG", "FactoMineR", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "proto", "tidyr", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "Rcpp", "stringr", "stringi", "magrittr", "R.oo", "R.methodsS3", "digest", "gtable", "MASS", "scales", "RColorBrewer", "dichromat", "munsell", "labeling", "colorspace", "Lmoments", "distillery", "car", "mgcv", "nnet", "pbkrtest", "quantreg", "nlme", "Matrix", "SparseM", "MatrixModels", "lattice", "minqa", "nloptr", "RcppEigen", "reshape", "fda", "fields", "spam", "maps", "latticeExtra", "cluster", "ellipse", "flashClust", "leaps", "scatterplot3d", "data.table", "dplyr", "knitr", "chron", "assertthat", "tibble", "lazyeval", "DBI", "BH", "evaluate", "formatR", "highr", "markdown", "yaml", "mime", "heplots", "mapproj", "hexbin", "mapdata", "RgoogleMaps", "png", "RJSONIO", "boot", "zoo", "XML", "selectr", "RCurl", "bitops", "httr", "memoise", "whisker", "rstudioapi", "jsonlite", "git2r", "withr", "curl", "openssl", "dendextend", "ggrepel", "abind", "fpc", "mclust", "flexmix", "prabclus", "class", "diptest", "mvtnorm", "robustbase", "kernlab", "trimcluster", "modeltools", "DEoptimR", "GlobalOptions", "shape", "urltools", "foreign", "haven", "readODS", "xml2", "readr", "feather", "cellranger")
success <- invisible(sapply(packs, function(x) length(find.package(x, quiet = TRUE))>0))
if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/RPackages"), type = "win.binary")
#success <- suppressWarnings(sapply(packs, require, character.only = TRUE))
#if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/RPackages"), type = "win.binary")
#require will ensure packages load correctly, but not sensible to load all
#sapply(names(success)[!success], require, character.only = TRUE)
#Needed when ggfortify was not on CRAN
#if(!suppressWarnings(require(ggfortify))) install.packages(paste0(getwd(), "/RPackages", "/ggfortify_0.1.0.tar.gz"), repos = NULL, type="source")
library(openxlsx)
library(reshape2)
library(lubridate)
library(plyr)
library(rtf)
library(ggplot2)
library(extRemes)
library(DAAG)
library(ggfortify)
library(GGally)
library(FactoMineR)
library(plotrix)
library(agridat)
library(candisc)
library(R6)
library(openair)
library(circular)
library(survival)
library(Evapotranspiration)
library(clifro)
library(devtools)
library(factoextra)
library(circlize)
library(CircStats)
library(rio)
library(readxl)
library(lme4)
library(dummies)
library(ggthemes)
library(dplyr)
setwd(dirname(parent.frame(2)$ofile))


source("instat_object_R6.R")
source("data_object_R6.R")
source("labels_and_defaults.R")
source("stand_alone_functions.R")
files <- sort(dir(file.path(getwd(), 'Backend_Components/'),pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)