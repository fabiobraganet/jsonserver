
FROM node:10-alpine

MAINTAINER fabio <fabio@magva.com.br>

RUN \
    echo "==> Install app..."                && \
    npm install -g --production json-server  && \
    \
    \
    echo "==> Remove unused temp..."         && \
    rm -rf /root/.npm                  \
           /usr/lib/node_modules/npm

EXPOSE 3000
VOLUME [ "/data" ]
WORKDIR /data

ENTRYPOINT ["json-server", "--host", "0.0.0.0", "--port", "3000", "db.json"]
CMD [""]